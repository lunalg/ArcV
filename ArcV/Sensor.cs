using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static ArcV.Program;

namespace ArcV
{
    public class Sensor
    {
        public int  sensorID;
        public int  towerID;
        public int  height;

        public Sensor (int sensID = 0, int towID = 0, int h = 0)
        {

            if (sensID != 0) //received non-default parameter
            {
                ArcV.Sensor sensorObj = getSensorObjByID(sensID);

                if (sensorObj.sensorID == 0) //Obj not found, received empty default, ok to add
                {
                    sensorID = sensID;
                    towerID = towID;
                    height = h;
                    addToGlobalSensorsList(this);
                    Console.WriteLine($"Success. Sensor ID {sensID} was added at {h}m in tower {towID}"); //better to insert in a log file instead of console. Skipping for now.

                }
                else //object already found
                {
                    Console.WriteLine($"Failed. Sensor ID {sensID} already exists"); //better to insert in a log file instead of console. Skipping for now.
                }
            }

        }

        public void addToGlobalSensorsList(ArcV.Sensor sensor)
        {
            ArcV.Globals.globalSensorsList.Add(sensor);
        }


    }
}
