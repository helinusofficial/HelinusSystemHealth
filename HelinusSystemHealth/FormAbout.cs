using HelinusSystemHealth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HelinusSystemHealth
{
    public partial class FormAbout : Form
    {
        internal Utilities utilities;
        public FormAbout()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            utilities = new Utilities();
            labelVer.Text = utilities.ShowAppVersion();
        }
        private void linkLabelCompanyLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = linkLabelCompanyLink.Text,
                UseShellExecute = true
            });
        }
    }
}