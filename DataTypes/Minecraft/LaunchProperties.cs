using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGenesis.Minecraft.DataTypes.Minecraft
{
    public struct LaunchProperties
    {
        public LaunchProperties() { }

        public struct JVMProperties
        {
            public JVMProperties() { }

            // Vanilla
            public string MaxHeapSize { get; set; }
            public string MinHeapSize { get; set; } = "128M";
            public GCType GC { get; set; } = GCType.G1GC;
            public bool UseAdaptiveSizePolicy { get; set; } = false;
            public bool OmitStackTraceInFastThrow { get; set; } = false;

            // Forge
            public bool FML_IgnoreInvalidMinecraftCertificates { get; set; } = true;
            public bool FML_IgnorePatchDiscrepancies { get; set; } = true;

            public enum GCType
            {
                G1GC,
                ZGC,
                SerialGC,
                ParallelGC
            }
        }
    }
}
