using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using FRC.NetworkTables.Interop;
using FRC.NetworkTables;


namespace Dash4572 {
    public class CameraSettings {

        NetworkTableInstance inst;

        NetworkTableEntry autoExposureEntry;
        NetworkTableEntry brightnessEntry;
        NetworkTableEntry contrastEntry;
        NetworkTableEntry exposureEntry;
        NetworkTableEntry gammaEntry;
        NetworkTableEntry saturationEntry;
        NetworkTableEntry frameRateEntry;

        public CameraSettings(NetworkTableInstance inst, string tableName) {
            autoExposureEntry = inst.GetTable(tableName).GetEntry("autoExposure");
            brightnessEntry = inst.GetTable(tableName).GetEntry("brightness");
            contrastEntry = inst.GetTable(tableName).GetEntry("contrast");
            exposureEntry = inst.GetTable(tableName).GetEntry("exposure");
            gammaEntry = inst.GetTable(tableName).GetEntry("gamma");
            saturationEntry = inst.GetTable(tableName).GetEntry("saturation");
            frameRateEntry = inst.GetTable(tableName).GetEntry("frameRate");
        }

        public bool AutoExposure {
            get { return this.autoExposureEntry.GetBoolean(false); }
            set { 
                this.autoExposureEntry.SetBoolean(value); 
            }
        }

        public double Brightness {
            get { return this.brightnessEntry.GetDouble(0.0); }
            set {
                System.Console.WriteLine("entered set brightness");
                this.brightnessEntry.SetDouble(value); 
            }
        }

        public double Contrast {
            get { return this.contrastEntry.GetDouble(0.0); }
            set { this.contrastEntry.SetDouble(value); }
        }

        public double Exposure {
            get { return this.exposureEntry.GetDouble(1.0); }
            set { this.exposureEntry.SetDouble(value); }
        }

        public double Gamma {
            get { return this.gammaEntry.GetDouble(100.0); }
            set { this.gammaEntry.SetDouble(value); }
        }

        public double Saturation {
            get { return this.saturationEntry.GetDouble(0.0); }
            set { this.saturationEntry.SetDouble(value); }
        }


        public int FrameRate {
            get { return (int) this.frameRateEntry.GetDouble(-1.0); }
        }


    }
}
