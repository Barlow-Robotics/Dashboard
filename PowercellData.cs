using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FRC.NetworkTables.Interop;
using FRC.NetworkTables;

namespace Dash4572 {
    public class PowercellData {

        NetworkTableInstance inst;
        NetworkTableEntry canSeePowercellEntry;
        NetworkTableEntry powercellAngleEntry;
        NetworkTableEntry powercellDistanceEntry;
 
        public PowercellData(NetworkTableInstance inst) {
            this.inst = inst;
            canSeePowercellEntry = inst.GetTable("vision").GetEntry("canSeePowercell");
//            powercellAngleEntry = inst.GetTable("vision").GetEntry("pcAngle");
            powercellAngleEntry = inst.GetTable("vision").GetEntry("powercellAngle");
            powercellDistanceEntry = inst.GetTable("vision").GetEntry("powercellDistance");
        }

        public bool CanSeePowercell {
            get { return this.canSeePowercellEntry.GetBoolean(false); }
    //        set { this.canSeeTargetEntry.GetBoolean(value); }
        }

        public double Angle {
            get { return this.powercellAngleEntry.GetDouble(-1.0) * 180.0 / Math.PI; }
        }


        public double Distance {
            get { return this.powercellDistanceEntry.GetDouble(0.0); }
        }


    }
}
