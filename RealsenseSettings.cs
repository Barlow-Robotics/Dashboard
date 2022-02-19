using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using FRC.NetworkTables.Interop;
using FRC.NetworkTables;


namespace Dash4572 {
    public class RealSenseSettings {

        NetworkTableInstance inst;

        NetworkTableEntry autoExposureEntry;
        NetworkTableEntry brightnessEntry;
        NetworkTableEntry contrastEntry;
        NetworkTableEntry exposureEntry;
        NetworkTableEntry gammaEntry;
        NetworkTableEntry saturationEntry;

        public RealSenseSettings(NetworkTableInstance inst) {
            autoExposureEntry = inst.GetTable("real_sense").GetEntry("autoExposure");
            brightnessEntry = inst.GetTable("real_sense").GetEntry("brightness");
            contrastEntry = inst.GetTable("real_sense").GetEntry("contrast");
            exposureEntry = inst.GetTable("real_sense").GetEntry("exposure");
            gammaEntry = inst.GetTable("real_sense").GetEntry("gamma");
            saturationEntry = inst.GetTable("real_sense").GetEntry("saturation");
        }

        public bool AutoExposure {
            get { return this.autoExposureEntry.GetBoolean(false); }
            set { 
                this.autoExposureEntry.GetBoolean(value); 
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
            get { return this.exposureEntry.GetDouble(0.0); }
            set { this.exposureEntry.SetDouble(value); }
        }

        public double Gamma {
            get { return this.gammaEntry.GetDouble(0.0); }
            set { this.gammaEntry.SetDouble(value); }
        }

        public double Saturation {
            get { return this.saturationEntry.GetDouble(0.0); }
            set { this.saturationEntry.SetDouble(value); }
        }


    }
}
