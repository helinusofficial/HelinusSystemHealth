using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// تابع خواندن مدل دیسک
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace HelinusSystemHealth.HDD
{

    // ساختارها و API ها
    [StructLayout(LayoutKind.Sequential)]
    struct SENDCMDINPARAMS
    {
        public uint cBufferSize;
        public IDEREGS irDriveRegs;
        public uint dwDriveNumber;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] bReserved;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public uint[] dwReserved;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
        public byte[] bBuffer;
    }

    [StructLayout(LayoutKind.Sequential)]
    struct IDEREGS
    {
        public byte bFeaturesReg;
        public byte bSectorCountReg;
        public byte bSectorNumberReg;
        public byte bCylLowReg;
        public byte bCylHighReg;
        public byte bDriveHeadReg;
        public byte bCommandReg;
        public byte bReserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    struct DRIVERSTATUS
    {
        public byte bDriverError;
        public byte bIDEStatus;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] bReserved;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] dwReserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    struct SENDCMDOUTPARAMS
    {
        public uint cBufferSize;
        public DRIVERSTATUS DriverStatus;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
        public byte[] bBuffer;
    }
    static class NativeMethods
    {
        public const uint SMART_GET_VERSION = 0x00074080;
        public const uint SMART_RCV_DRIVE_DATA = 0x0007c088;
        public const byte SMART_CMD = 0xB0;
        public const byte SMART_READ_DATA = 0xD0;
        public const byte IDENTIFY_DRIVE = 0xEC;

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern SafeFileHandle CreateFile(
            string lpFileName, uint dwDesiredAccess, uint dwShareMode,
            IntPtr lpSecurityAttributes, uint dwCreationDisposition,
            uint dwFlagsAndAttributes, IntPtr hTemplateFile);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool DeviceIoControl(
            SafeFileHandle hDevice, uint dwIoControlCode,
            [In] ref SENDCMDINPARAMS lpInBuffer, int nInBufferSize,
            [Out] out SENDCMDOUTPARAMS lpOutBuffer, int nOutBufferSize,
            out uint lpBytesReturned, IntPtr lpOverlapped);


    }
}
