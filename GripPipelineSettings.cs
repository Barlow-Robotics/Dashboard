using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using FRC.NetworkTables.Interop;
using FRC.NetworkTables;


namespace Dash4572 {
    public class GripPipelineSettings {

        NetworkTableInstance inst;
        string tableName = "";

        NetworkTableEntry hueLowerEntry;
        NetworkTableEntry hueUpperEntry;
        NetworkTableEntry saturationLowerEntry;
        NetworkTableEntry saturationUpperEntry;
        NetworkTableEntry luminocityLowerEntry;
        NetworkTableEntry luminocityUpperEntry;

        public GripPipelineSettings(NetworkTableInstance inst, string tableName) {
            this.inst = inst;
            this.tableName = tableName;
            hueLowerEntry = inst.GetTable(tableName).GetEntry("hslHueLower");
            hueUpperEntry = inst.GetTable(tableName).GetEntry("hslHueUpper");
            saturationLowerEntry = inst.GetTable(tableName).GetEntry("hslSaturationLower");
            saturationUpperEntry = inst.GetTable(tableName).GetEntry("hslSaturationUpper");
            luminocityLowerEntry = inst.GetTable(tableName).GetEntry("hslLuminocityLower");
            luminocityUpperEntry = inst.GetTable(tableName).GetEntry("hslLuminocityUpper");
        }

        public double HueLower {
            get { return hueLowerEntry.GetDouble(0.0); }
            set { hueLowerEntry.SetDouble(value); }
        }

        public double HueUpper {
            get { return hueUpperEntry.GetDouble(0.0); }
            set { hueUpperEntry.SetDouble(value); }
        }


        public double SaturationLower {
            get { return saturationLowerEntry.GetDouble(0.0); }
            set { saturationLowerEntry.SetDouble(value); }
        }

        public double SaturationUpper {
            get { return saturationUpperEntry.GetDouble(0.0); }
            set { saturationUpperEntry.SetDouble(value); }
        }

        public double LuminocityLower {
            get { return luminocityLowerEntry.GetDouble(0.0); }
            set { luminocityLowerEntry.SetDouble(value); }
        }

        public double LuminocityUpper {
            get { return luminocityUpperEntry.GetDouble(0.0); }
            set { luminocityUpperEntry.SetDouble(value); }
        }



    }
}
