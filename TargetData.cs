using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FRC.NetworkTables.Interop;
using FRC.NetworkTables;

namespace Dash4572 {
    public class TargetData {

        NetworkTableInstance inst;
        NetworkTableEntry canSeeTargetEntry;
        NetworkTableEntry targetAngleEntry;
        NetworkTableEntry targetDistanceEntry;
        NetworkTableEntry streamTargetVideoEntry ;

        public TargetData(NetworkTableInstance inst) {
            this.inst = inst;
            canSeeTargetEntry = inst.GetTable("vision").GetEntry("canSeeTarget");
            targetAngleEntry = inst.GetTable("vision").GetEntry("targetAngle");
            targetDistanceEntry = inst.GetTable("vision").GetEntry("targetDistance");
            streamTargetVideoEntry = inst.GetTable("vision").GetEntry("streamTargetVideo");
        }

        public bool CanSeeTarget {
            get { return this.canSeeTargetEntry.GetBoolean(false); }
    //        set { this.canSeeTargetEntry.GetBoolean(value); }
        }

        public double Angle {
            get { return this.targetAngleEntry.GetDouble(0.0) * 180.0 / Math.PI; }
    //        set { this.targetAngleEntry.SetDouble(0.0);  }
        }


        public double Distance {
            get { return this.targetDistanceEntry.GetDouble(0.0); }
        }

        public bool StreamVideo {
            get { return this.streamTargetVideoEntry.GetBoolean(false); }
            set { this.streamTargetVideoEntry.SetBoolean(value); }
        }


    }
}
