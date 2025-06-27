using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HelinusSystemHealth.HDD
{
    internal class HDDSrv
    {
      public  string GetDriveModel(int driveNumber)
        {
            string path = $"\\\\.\\PhysicalDrive{driveNumber}";
            var hDevice = NativeMethods.CreateFile(path, 0xC0000000, 3, IntPtr.Zero, 3, 0, IntPtr.Zero);
            if (hDevice.IsInvalid)
                return null;

            var cmd = new SENDCMDINPARAMS
            {
                cBufferSize = 512,
                irDriveRegs = new IDEREGS
                {
                    bCommandReg = NativeMethods.IDENTIFY_DRIVE,
                    bDriveHeadReg = (byte)(0xA0 | ((driveNumber & 1) << 4))
                },
                dwDriveNumber = (uint)driveNumber,
                bReserved = new byte[3],
                dwReserved = new uint[4],
                bBuffer = new byte[512]
            };

            bool result = NativeMethods.DeviceIoControl(hDevice,
                NativeMethods.SMART_RCV_DRIVE_DATA,
                ref cmd, Marshal.SizeOf(cmd),
                out var outParams, Marshal.SizeOf(typeof(SENDCMDOUTPARAMS)),
                out uint bytesReturned, IntPtr.Zero);

            if (!result)
                return null;

            byte[] modelBytes = new byte[40];
            Array.Copy(outParams.bBuffer, 54, modelBytes, 0, 40);

            for (int i = 0; i < modelBytes.Length; i += 2)
            {
                byte temp = modelBytes[i];
                modelBytes[i] = modelBytes[i + 1];
                modelBytes[i + 1] = temp;
            }

            return System.Text.Encoding.ASCII.GetString(modelBytes).Trim();
        }
        // تابع خواندن دمای دیسک
      public  int? GetDriveTemperature(int driveNumber)
        {
            string path = $"\\\\.\\PhysicalDrive{driveNumber}";
            var hDevice = NativeMethods.CreateFile(path, 0xC0000000, 3, IntPtr.Zero, 3, 0, IntPtr.Zero);
            if (hDevice.IsInvalid)
                return null;

            var cmd = new SENDCMDINPARAMS
            {
                cBufferSize = 512,
                irDriveRegs = new IDEREGS
                {
                    bCommandReg = NativeMethods.SMART_CMD,
                    bFeaturesReg = NativeMethods.SMART_READ_DATA,
                    bSectorCountReg = 1,
                    bSectorNumberReg = 1,
                    bCylLowReg = 0x4F,
                    bCylHighReg = 0xC2,
                    bDriveHeadReg = (byte)(0xA0 | ((driveNumber & 1) << 4))
                },
                dwDriveNumber = (uint)driveNumber,
                bReserved = new byte[3],
                dwReserved = new uint[4],
                bBuffer = new byte[512]
            };

            bool result = NativeMethods.DeviceIoControl(hDevice,
                NativeMethods.SMART_RCV_DRIVE_DATA,
                ref cmd, Marshal.SizeOf(cmd),
                out var outParams, Marshal.SizeOf(typeof(SENDCMDOUTPARAMS)),
                out uint bytesReturned, IntPtr.Zero);

            if (!result)
                return null;

            for (int i = 2; i < 512 - 12; i += 12)
            {
                byte attrId = outParams.bBuffer[i];
                if (attrId == 0xC2) // temperature attribute
                {
                    return outParams.bBuffer[i + 5]; // temperature value
                }
            }

            return null;
        }
    }
}
