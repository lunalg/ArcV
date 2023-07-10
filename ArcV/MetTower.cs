using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ArcV.Program;
using static ArcV.Globals;
using System.Diagnostics.Contracts;

namespace ArcV
{
    public class MetTower
    {
        public int areaID;
        public int towerID;
        public List<int> sensorList;          //List of sensor IDs in the met tower


        public MetTower(int aID = 0, int towID = 0, List<int> sensList = null )
        {
            sensorList = sensList ?? new List<int>(); //this is to prevent null assignment, creating an empty obj instead

            if (towID != 0) //received non-default parameter 
            { 
                ArcV.MetTower TowerObj = getTowerObjByID(towID);

                if (TowerObj.towerID==0) //Obj not found, received empty default, ok to add
                {
                    areaID = aID;
                    towerID = towID;
                    sensorList = sensList ?? new List<int>(); //this is to prevent null assignment, creating an empty obj instead
                    addToGlobalTowersList(this); //we would need to also check if sensors in the sensorList are not associated to other tower, skipping for now
                    Console.WriteLine($"Success. Tower ID {towID} was added in area {aID}"); //better to insert in a log file instead of console. Skipping for now.
                }
                else
                {
                    Console.WriteLine($"Failed. Tower ID {towID} already exists"); //better to insert in a log file instead of console. Skipping for now.
                }
            }

        }

        public void addToGlobalTowersList(ArcV.MetTower tower)
        {
            ArcV.Globals.globalTowersList.Add(tower);
        }

    }

}