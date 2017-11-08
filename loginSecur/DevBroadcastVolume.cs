using System;
using System.Runtime.InteropServices;

namespace loginSecur
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DevBroadcastVolume
    {
        public int Size;
        public int DeviceType;
        public int Reserved;
        public int Mask;
        public Int16 Flags;
    }
}
