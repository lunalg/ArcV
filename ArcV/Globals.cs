using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ArcV.Measurement;
using static ArcV.Sensor;
using static ArcV.MetTower;
using static ArcV.Area;

namespace ArcV
{
    public static class Globals
    {
        public static List<ArcV.Measurement> globalMeasurementsList = new List<ArcV.Measurement>();
        public static List<ArcV.Sensor> globalSensorsList = new List<ArcV.Sensor>();
        public static List<ArcV.MetTower> globalTowersList = new List<ArcV.MetTower>();
        public static List<ArcV.Area> globalAreasList = new List<ArcV.Area>();

    }

}
