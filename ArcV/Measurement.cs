using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcV
{
    public class Measurement
    {
        public int sensorID;
        public DateTime initialInterval; //final interval is 10 min after the initial interval
        public float wDir;
        public float avSpeed;
        public float maxSpeed;
        public float minSpeed;
        public float stdDeviation;
        public bool  qualitycheck; //false if data is not reliable

        public Measurement (int sensID, DateTime start, float dir, float avS, float maxS, float minS, float stdD, bool qcheck  )
        {
            sensorID = sensID;
            initialInterval= start;
            wDir = dir;
            avSpeed = avS;
            maxSpeed= maxS;
            minSpeed= minS;
            stdDeviation= stdD;
            qualitycheck= qcheck;
            addToGlobalMeasurementsList(this);
        }

        public void addToGlobalMeasurementsList(Measurement measurement)
        {
            ArcV.Globals.globalMeasurementsList.Add(measurement);
            Console.WriteLine("Measurement added."); //ideally it would be sent to a log
        }

    }

}
