
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using static ArcV.Measurement;

namespace ArcV
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Areas

            Console.WriteLine("..............................");
            Console.WriteLine("            Areas             ");
            Console.WriteLine("..............................");

            Console.WriteLine($"Global Area List Size: {Globals.globalAreasList.Count()}");

            Console.WriteLine("Adding Area 1 with ID=1...");
            new Area(1, new List<int> {1, 2, 3, 4 });
            Console.WriteLine($"Global Area List Size: {Globals.globalAreasList.Count()}");
            Console.WriteLine($"Global Area List[0].ID: {Globals.globalAreasList[0].areaID}");

            Console.WriteLine("Trying to add Area 2 with same ID=1...");
            new Area(1, new List<int> { 5 });
            Console.WriteLine($"Global Area List Size: {Globals.globalAreasList.Count()}");

            Console.WriteLine("Now Trying to add Area 2 with ID=2...");
            new Area(2, new List<int> { 5 });
            Console.WriteLine($"Global Area List Size: {Globals.globalAreasList.Count()}");
            Console.WriteLine($"Global Area List[1].ID: {Globals.globalAreasList[1].areaID}");

            Console.WriteLine("...............................");
            Console.WriteLine("            Towers             ");
            Console.WriteLine("...............................");

            Console.WriteLine("Adding Tower 1 with ID=1...");
            new MetTower(1, 1, new List<int> { 1 });
            Console.WriteLine($"Global Tower List Size: {Globals.globalTowersList.Count()}");
            Console.WriteLine($"Global Tower List[0].ID: {Globals.globalTowersList[0].areaID}");

            Console.WriteLine("Trying to add Tower 2 with same ID=1...");
            new MetTower(1, 1, new List<int> { 2, 3 });
            Console.WriteLine($"Global Towers List Size: {Globals.globalTowersList.Count()}");

            Console.WriteLine("Now Trying to add Tower 2 with ID=2...");
            new MetTower(1, 2, new List<int> { 2, 3 });
            Console.WriteLine($"Global Towers List Size: {Globals.globalTowersList.Count()}");
            Console.WriteLine($"Global Towers List[1].ID: {Globals.globalTowersList[1].towerID}");

            Console.WriteLine("Adding more towers...");
            new MetTower(1, 3, new List<int> { 4 });
            new MetTower(1, 4, new List<int> { 5 });
            new MetTower(2, 5, new List<int> { 6 });
            Console.WriteLine($"Global Towers List Size: {Globals.globalTowersList.Count()}");

            Console.WriteLine("...............................");
            Console.WriteLine("            Sensors            ");
            Console.WriteLine("...............................");

            Console.WriteLine("Adding Sensor 1 with ID=1...");
            new Sensor (1, 1, 30);
            Console.WriteLine($"Global Sensor List Size: {Globals.globalSensorsList.Count()}");
            Console.WriteLine($"Global Sensor List[0].ID: {Globals.globalSensorsList[0].sensorID}");

            Console.WriteLine("Trying to add Sensor 2 with same ID=1...");
            new Sensor(1, 1, 30);
            Console.WriteLine($"Global Sensors List Size: {Globals.globalSensorsList.Count()}");

            Console.WriteLine("Now Trying to add Sensor 2 with ID=2...");
            new Sensor(2, 2, 30);
            Console.WriteLine($"Global Sensors List Size: {Globals.globalSensorsList.Count()}");
            Console.WriteLine($"Global Sensor List[1].ID: {Globals.globalSensorsList[1].sensorID}");

            Console.WriteLine("Adding more sensors...");
            new Sensor(3, 2, 45);
            new Sensor(4, 3, 60);
            new Sensor(5, 4, 60);
            new Sensor(6, 5, 60);

            Console.WriteLine("...............................");
            Console.WriteLine("          Measurements         ");
            Console.WriteLine("...............................");

            Console.WriteLine("Adding Measurements....");

            new Measurement(1, new DateTime(2023, 07, 08, 9, 0, 0), 45, 10, 20, 0, 5, true);
            new Measurement(1, new DateTime(2023, 07, 08, 9, 10, 0), 45, 10, 20, 0, 5, true);

            new Measurement(2, new DateTime(2023, 07, 08, 9, 0, 0), 45, 10, 20, 0, 5, true);
            new Measurement(2, new DateTime(2023, 07, 08, 9, 10, 0), 45, 10, 20, 0, 5, true);

            new Measurement(3, new DateTime(2023, 07, 08, 9, 0, 0), 45, 10, 20, 0, 5, true);
            new Measurement(3, new DateTime(2023, 07, 08, 9, 10, 0), 45, 10, 20, 0, 5, true);
            new Measurement(3, new DateTime(2023, 07, 08, 9, 20, 0), 45, 10, 20, 0, 5, true);
            new Measurement(3, new DateTime(2023, 07, 08, 9, 30, 0), 45, 10, 20, 0, 5, true);
            new Measurement(3, new DateTime(2023, 07, 08, 9, 40, 0), 45, 10, 20, 0, 5, true);
            new Measurement(3, new DateTime(2023, 07, 08, 9, 50, 0), 45, 10, 20, 0, 5, true);
            new Measurement(3, new DateTime(2023, 07, 08, 10, 0, 0), 45, 10, 20, 0, 5, true);

            new Measurement(4, new DateTime(2023, 07, 08, 9, 0, 0), 45, 11, 12, 10, 0.5f, true);

            new Measurement(5, new DateTime(2023, 07, 08, 9, 0, 0), 45, 12, 13, 11, 0.5f, true);

            new Measurement(6, new DateTime(2023, 07, 08, 9, 0,  0), 45, 10, 20, 0, 5, true);
            new Measurement(6, new DateTime(2023, 07, 08, 9, 10, 0), 45, 10, 20, 0, 5, true);
            new Measurement(6, new DateTime(2023, 07, 08, 9, 20, 0), 45, 20, 25, 15, 2.5f, false);
            new Measurement(6, new DateTime(2023, 07, 08, 9, 30, 0), 45, 20, 25, 15, 2.5f, false);

            Console.WriteLine($"Global Measurements List Size: {Globals.globalMeasurementsList.Count()}");


            Console.WriteLine("...............................");
            Console.WriteLine("         Getting Averages      ");
            Console.WriteLine("...............................");

            Console.WriteLine("Getting average for towerID=1 from 2023-07-08 9:00:00 to 2023-07-08 9:30:00");
            Console.WriteLine("Expected: 10");
            float s1= getAverageSpeedForTowerOverTime(1, new DateTime(2023, 07, 08, 9, 00, 0), new DateTime(2023, 07, 08, 9, 30, 0));
            Console.WriteLine($"Obtained: {s1}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Getting average for towerID=2 from 2023-07-08 9:00:00 to 2023-07-08 9:30:00");
            Console.WriteLine("Expected: 10");
            float s2 = getAverageSpeedForTowerOverTime(2, new DateTime(2023, 07, 08, 9, 00, 0), new DateTime(2023, 07, 08, 9, 30, 0));
            Console.WriteLine($"Obtained: {s2}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Getting average for areaID=1 from 2023-07-08 9:00:00 to 2023-07-08 10:30:00");
            Console.WriteLine("Expected: 10.2307");
            float s3 = getAverageSpeedForAreaOverTime(1, new DateTime(2023, 07, 08, 9, 00, 0), new DateTime(2023, 07, 08, 10, 30, 0));
            Console.WriteLine($"Obtained: {s3}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Getting average for areaID=2 from 2023-07-08 9:00:00 to 2023-07-08 10:00:00");
            Console.WriteLine("Expected: 10");
            float s4 = getAverageSpeedForAreaOverTime(2, new DateTime(2023, 07, 08, 9, 00, 0), new DateTime(2023, 07, 08, 10, 00, 0));
            Console.WriteLine($"Obtained: {s4}");

            Console.WriteLine("..........................................");
            Console.WriteLine("         Getting Wind Shear Exponent      ");
            Console.WriteLine("..........................................");
            Console.WriteLine("Getting Wind Shear Exponent for Area 1");
            Console.WriteLine("Expected: 0.2016");
            Console.WriteLine($"Obtained:{getWindShearExponent(1)}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Getting Wind Shear Exponent for Area 2");
            Console.WriteLine("Expected: 0.143");
            Console.WriteLine($"Obtained: {getWindShearExponent(2)}");
            Console.WriteLine("------------------------");


        }

        public static float getAverageSpeedForTowerOverTime (int towID, DateTime startTime, DateTime endTime)
        {

            List<Measurement> measurementsInTowerID = getMeasurementsByTower(towID);
            Console.WriteLine($"Size of measurementsInTowerID:{measurementsInTowerID.Count()}");

            float average = getAverageOverTime(measurementsInTowerID, startTime, endTime);

            return average;    
        }

        public static List<Measurement> getMeasurementsByTower(int towID)
        {
            
            MetTower tower = getTowerObjByID(towID);

            List<Measurement> measurementsInTower = getMeasurementsFromSensorList(tower.sensorList);
            
            return measurementsInTower;
        }

        public static MetTower getTowerObjByID(int towID)
        {

            foreach (MetTower tower in Globals.globalTowersList)
            {
                if (tower.towerID == towID) return tower;
            }

            MetTower emptyTowerObj = new MetTower();

            return emptyTowerObj;
        }

        public static List<Measurement> getMeasurementsFromSensorList(List<int> sensorIDs)
        {
            List<Measurement> sensorMeasurements = new List<Measurement>();

            foreach (Measurement measurement in Globals.globalMeasurementsList)
            {

                if (sensorIDs.Contains(measurement.sensorID)) sensorMeasurements.Add(measurement);
            }

            return sensorMeasurements;
        }

        public static float getAverageOverTime(List<Measurement> listofMeasurements, DateTime startTime, DateTime endTime)
        {
            /* 

             * Parameters:

                listofMeasurements - List of measurements to consider in calculation - it is assumed that this list is previously
                                    filtered according to a given criteria, e.g: height, towerID, Area, etc

                startTime, endTime - start and ending time of interest

             * Calculation:
             
                For measurements in listofMeasurement we will filter those with startTime <= Measurement.initialInterval < endTime,
                and then take the average of the remaining Measurement.avSpeed values, or return 0 if there are no measurements that satisfy the criteria 
          
             * Note:
             
                It should be noted that taking average of averages in a period is not the same as taking the average over that period.
                For taking exact average, we need the entire timeseries of the period. Here we assume that the 10min-data aggregation
                is good enough for our purposes.

             */

            float sum = 0f;
            int nValidMeasurements = 0;

            foreach (Measurement measurement in listofMeasurements)
            {
           
                if ((measurement.initialInterval >= startTime) && (measurement.initialInterval < endTime) && (measurement.qualitycheck))
                {
                    nValidMeasurements++;
                    sum += measurement.avSpeed;
                }

            }

            if (nValidMeasurements == 0) 
            {
                Console.WriteLine("No valid measurements to calculate AvSpeed. Returning 0."); //better to insert in a log file instead of console. Skipping for now.
                return 0f;
            }

            return sum / nValidMeasurements;

        }

        public static float getAverageSpeedForAreaOverTime(int areaID, DateTime startTime, DateTime endTime)
        {

            List<Measurement> measurementsInAreaID = getMeasurementsByArea(areaID);
            Console.WriteLine($"Size of measurementsInAreaID:{measurementsInAreaID.Count()}");

            float average = getAverageOverTime(measurementsInAreaID, startTime, endTime);

            return average;
        }

        public static double getWindShearExponent(int area)
        {
            /*
             * This function gets the Wind Shear Exponent in the given area by applying the formula
             * (v1 / v2) = (h1/h2)^windShearExponent. This formula is often used in the US.
             * 
             * The procedure used is to select h1 and h2 as the heights with more sensors in the area,
             * calculate the average speeds in h1 (v1) and h2 (v2), and then get the coefficient by the formula.
             * 
             * We could have gotten any two heights (simpler, but less accurate) or get the two heights with more
             * measurements (instead of more sensors). It was chosen to get heights with more sensors because sensors
             * are spread out within the area and can tell more about differences in the ground (the more uneven a
             * terrain is, the more different the measurements will be between sensors located at the same height)
             *  
             */

            double windShearExponent = 0.143d;
            int h1 = 0;
            int h2 = 0;
            int n1 = 0; //number of sensors in h1
            int n2 = 0; //number of sensors in h2
            float v1 = 0;
            float v2 = 0;

            List<Measurement> areaListOfMeasurements = getMeasurementsByArea(area);
            List<int> areaListOfSensors = getSensorIDsByArea(area);
            Dictionary<int, List<float>> heightAndSpeedDict = getHeightAndSpeedsDict(areaListOfMeasurements);
            Dictionary<int, List<int>> heightAndSensorDict = getHeightAndSensorsDict(areaListOfSensors);

            foreach ((int height, List<int> sensorList) in heightAndSensorDict)
            {
                //if the number of sensors is greater for this height and we have speed measurements, then proceed
                //(better would be to also check qcode instead of only Count(), but skipping for now)               

                if ((sensorList.Count() > n1) && (heightAndSpeedDict[height].Count() > 0)) 
                {
                    h2 = h1;
                    v2 = v1;
                    n2 = n1;
                    h1 = height;
                    v1 = heightAndSpeedDict[height].AsQueryable().Sum() / heightAndSpeedDict[height].Count();
                    n1 = sensorList.Count();

                }
                else if ((sensorList.Count() > n2) && (heightAndSpeedDict[height].Count() > 0))
                {
                    n2 = sensorList.Count();
                    h2 = height;
                    v2 = heightAndSpeedDict[height].AsQueryable().Sum() / heightAndSpeedDict[height].Count();

                }

            }

            if ((h1 > 0) && (h2 > 0)) //It is assumed that no sensor is located at 0m.
            {                        //Hence, if either h1 or h2 are zero, it was not possible to find enough heigths for calculation

                windShearExponent = h1 > h2 ? Math.Log(v1 / v2) / Math.Log(h1 / h2) : Math.Log(v2 / v1) / Math.Log(h2 / h1);
            }

            return windShearExponent;

        }

        public static List<ArcV.Measurement> getMeasurementsByArea(int areaID)
        {
            
            ArcV.Area area = getAreaObjByID(areaID);

            List<ArcV.Measurement> measurementsInArea = getMeasurementsFromTowersList(area.towerList);

            return measurementsInArea;
        }

        public static Area getAreaObjByID(int areaID)
        {

            foreach (ArcV.Area area in ArcV.Globals.globalAreasList)
            {
                if (area.areaID == areaID) return area;
            }

            ArcV.Area emptyAreaObj = new ArcV.Area();

            return emptyAreaObj;
        }

        public static List<Measurement> getMeasurementsFromTowersList(List<int> towerIDs)
        {
            List<ArcV.Measurement> measurementsInTowerList = new List<ArcV.Measurement>();

            foreach (MetTower tower in Globals.globalTowersList)
            {
                if (towerIDs.Contains(tower.towerID))
                {
                    List<Measurement> MeasurementsToAdd = getMeasurementsByTower(tower.towerID);
                    measurementsInTowerList = measurementsInTowerList.Concat(MeasurementsToAdd).ToList();
                }

            }

            return measurementsInTowerList;
        }

        public static List<int> getSensorIDsByArea(int areaID)
        {

            Area area = getAreaObjByID(areaID);

            List<int> sensorsIDsInArea = new List<int>();

            foreach (int tower in area.towerList) 
            {
                MetTower towerObj = getTowerObjByID(tower);
                List<int> sensorsToAdd = towerObj.sensorList;
                sensorsIDsInArea = sensorsIDsInArea.Concat(sensorsToAdd).ToList();
            }

            return sensorsIDsInArea;
        }

        public static Dictionary<int, List<int>> getHeightAndSensorsDict(List<int> sensorIDList) 
        {

            // From the given sensors List, provides a dictionary with list of sensorIDs by height

          
            Dictionary<int, List<int>> heightAndSensorsDict = new Dictionary<int, List<int>>();


            foreach (int sensorID in sensorIDList)
            {
                Sensor sensor = getSensorObjByID(sensorID);

                if (heightAndSensorsDict.ContainsKey(sensor.height))
                {
                    if (!heightAndSensorsDict[sensor.height].Contains(sensor.sensorID))
                    heightAndSensorsDict[sensor.height].Add(sensor.sensorID);
                }
                else
                {
                    List<int> sensorListAtGivenHeight = new List<int> { sensor.sensorID };
                    heightAndSensorsDict.Add(sensor.height, sensorListAtGivenHeight);
                }

            }

            Console.WriteLine("heightAndSensorsDict:");
            foreach ((int height, List< int > sensorListAtGivenHeight) in heightAndSensorsDict)
            {
                Console.WriteLine($"h:{height}: SensorList Size:{sensorListAtGivenHeight.Count()}");

            }

            return heightAndSensorsDict;
        }

        public static Sensor getSensorObjByID(int sID)
        {

            foreach (Sensor sensor in Globals.globalSensorsList)
            {
                if (sensor.sensorID == sID) return sensor;
            }

            Sensor emptySensorObj = new Sensor();

            return emptySensorObj;
        }

        public static Dictionary<int, List<float>> getHeightAndSpeedsDict(List<Measurement> measurementList)
        {

            // From the given measurementList, provides a dictionary with list of avSpeed measurements by height

            Dictionary<int, List<float>> heightAndSpeedsDict = new Dictionary<int, List<float>>();

            foreach (Measurement measurement in measurementList)
            {
                Sensor sensor = getSensorObjByID(measurement.sensorID);

                if (heightAndSpeedsDict.ContainsKey(sensor.height))
                {
                    heightAndSpeedsDict[sensor.height].Add(measurement.avSpeed);
                }
                else
                {
                    List<float> avSpeed = new List<float> { measurement.avSpeed };
                    heightAndSpeedsDict.Add(sensor.height, avSpeed);
                }

            }

            Console.WriteLine("heightAndSpeedsDict:");
            foreach ((int height, List<float> speedsList) in heightAndSpeedsDict)
            {
                Console.WriteLine($"h:{height}: speedsList Size:{speedsList.Count()}");

            }

            return heightAndSpeedsDict;
        }


    }

}