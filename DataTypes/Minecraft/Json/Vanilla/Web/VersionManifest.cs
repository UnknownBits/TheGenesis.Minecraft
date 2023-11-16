using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGenesis.Minecraft.DataTypes.Minecraft.Json.Vanilla.Web
{
    public struct VersionManifest
    {
        public struct LatestVersion
        {
            public string release;
            public string snapshot;
        }

        public LatestVersion latest;

        public struct Versions
        {
            public string id;

            public enum Type
            {
                release,
                snapshot,
                old_beta,
                old_alpha
            }

            public Type type;
            public string url;
            public DateTime time;
            public DateTime releaseTime;
            public string sha1;
            public int complianceLevel;
        }
    }
}
