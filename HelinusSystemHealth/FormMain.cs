using HelinusSystemHealth.HDD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace HelinusSystemHealth
{
    public partial class FormMain : Form
    {
        #region VariableRegion
        internal Utilities utilities;
        Thread th_Timer;
        int th_Timer_Time = 5000;//1 second
        bool workStatus = false;
        #endregion

        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            utilities = new Utilities();
            toolStripStatusLabelVer.Text = "Ver:" + utilities.ShowAppVersion();
            Init();
        }

        #region EventRegion

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Init();
            workStatus = true;
            th_Timer.Start();
            ChangeComponents(true);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            ShutdownApp(false,false);
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            Environment.Exit(0);
            //Application.ExitThread();
            // Invoke(new MethodInvoker(delegate { Application.Exit(); }));

        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShutdownApp(false,true);
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                HideMainForm();
            }
        }
        private void toolStripMenuItemShow_Click(object sender, EventArgs e)
        {
            ShowMainForm();
        }
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }
        #endregion

        #region MethodRegion
        private void Init()
        {
            utilities = new Utilities();
            th_Timer = new Thread(new ThreadStart(TimerFunction));
        }
        private void ShutdownApp(bool stop,bool exitapp)
        {
            workStatus = false;
            if (th_Timer != null && th_Timer.ThreadState != ThreadState.Stopped &&
                th_Timer.ThreadState != ThreadState.Unstarted && !exitapp)
            {
                ChangeComponents(false);

                if (stop)
                    ShowMainForm();

                th_Timer.Join();
            }

            if (exitapp)
                Environment.Exit(0);
        }

        private HDDSrv hDDService;
        private void TimerFunction()
        {
            hDDService = new HDDSrv();


            while (th_Timer.IsAlive && workStatus)
            {
                try
                {
                    for (int i = 0; i < 2; i++)
                    {
                        string model = hDDService.GetDriveModel(i);
                        int? temp = hDDService.GetDriveTemperature(i);
                       
                        if (model != null && temp.HasValue)
                        {
                            if (temp.Value >= numericUpDownTemp.Value)
                            {
                                PrintLogMessage("Disk {i}: " + model + "\t Temp: " + temp.Value + "°C", true);
                                Console.Beep(6000, 5000);
                            }
                            else
                                PrintLogMessage("Disk " + i + ": " + model + "\t Temp: " + temp.Value + "°C", false);
                        }
                        else
                            PrintLogMessage("Disk "+i +": Not Available.", true);
                    }
                }
                catch (Exception err)
                {
                    Thread.Sleep(1000);
                }
                Thread.Sleep(th_Timer_Time);
            }
        }
        private void PrintLogMessage(string logMessage, bool red)
        {
            try
            {
                lock (this)
                {
                    if (red)
                    {
                        richTextBoxLogs.BeginInvoke((MethodInvoker)delegate ()
                        {
                            // int startIndex = richTextBoxLogs.GetFirstCharIndexFromLine(55);
                            richTextBoxLogs.Select(richTextBoxLogs.Text.Length, logMessage.Length - 1);
                            richTextBoxLogs.SelectionColor = System.Drawing.Color.Red;
                            //richTextBoxLogs.SelectionBackColor = System.Drawing.Color.Blue;
                            richTextBoxLogs.AppendText(LogSrv.LogMessageCreator(logMessage));
                            richTextBoxLogs.ScrollToCaret();
                        });
                    }
                    else
                        richTextBoxLogs.BeginInvoke((MethodInvoker)delegate ()
                        {
                            richTextBoxLogs.AppendText(LogSrv.LogMessageCreator(logMessage));
                            richTextBoxLogs.ScrollToCaret();
                        });
                }
            }
            catch
            {
            }
        }
        private void ChangeComponents(bool enableDisable)
        {
            try
            {
              
                numericUpDownTemp.BeginInvoke((MethodInvoker)delegate ()
                    {
                        numericUpDownTemp.Enabled = !enableDisable;
                    });
                buttonStart.BeginInvoke((MethodInvoker)delegate ()
                {
                    buttonStart.Enabled = !enableDisable;
                });
                buttonStop.BeginInvoke((MethodInvoker)delegate ()
                {
                    buttonStop.Enabled = enableDisable;
                });

                menuStripMain.BeginInvoke((MethodInvoker)delegate ()
                {
                    exitToolStripMenuItem.Enabled = !enableDisable;
                });
            }
            catch { }
        }

        private void HideMainForm()
        {
            this.Hide();
            this.Visible = false;
            this.Opacity = 0;
            //this is old code to hide main form in winform
            //this line not works by telerik forms
            // this.WindowState = FormWindowState.Minimized;
            this.Text = string.Empty;
            notifyIconMain.Visible = true;
        }
        private void ShowMainForm()
        {
            notifyIconMain.Visible = false;

            //this.Visible = true;
            //this.Text = "Helinus System Health | Davood Motevalizadeh";
            //this.Opacity = 100;
            //this.WindowState = FormWindowState.Normal;

            Invoke(new MethodInvoker(delegate { this.Visible = true; }));
            Invoke(new MethodInvoker(delegate { this.Text = "Helinus System Health | Davood Motevalizadeh"; }));
            Invoke(new MethodInvoker(delegate { this.Opacity = 100; }));
            Invoke(new MethodInvoker(delegate { this.WindowState = FormWindowState.Normal; }));
        }
        #endregion
    }
}