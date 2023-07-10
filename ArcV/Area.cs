using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static ArcV.Program;
using static ArcV.Globals;
using System.Security.Cryptography;

namespace ArcV
{
    public class Area
    {
        public int areaID;
        public List<int> towerList;          //List of tower IDs in the Area

        public Area (int aID = 0, List<int> towList = null)
        {
            towerList = towList ?? new List<int>(); //this is to avoid possible null assignment, by creating an empty obj instead

            if (aID != 0) //received non-default parameter
            {
                ArcV.Area areaObj = getAreaObjByID(aID);

                if (areaObj.areaID==0) //Obj not found, received empty default, ok to add
                {
                    areaID = aID;
                    towerList = towList ?? new List<int>(); //this is to avoid possible null assignment, by creating an empty obj instead
                    addToGlobalAreasList(this);
                    Console.WriteLine($"Success. Area ID {aID} was added"); //better to insert in a log file instead of console. Skipping for now.

                }
                else //object was found
                {
                    Console.WriteLine($"Failed. Area ID {aID} already exists"); //better to insert in a log file instead of console. Skipping for now.
                }
            }

        }

        public void addToGlobalAreasList(ArcV.Area area)
        {
            ArcV.Globals.globalAreasList.Add(area);
        }

    }
}
