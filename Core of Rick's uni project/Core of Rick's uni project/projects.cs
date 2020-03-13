using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core_of_Rick_s_uni_project
{
    class investigativeProjects
    {
        
        public string diseaseName;
        public int dealingValue;
        public int rewardValue;
        public int investigativeNum;

        private investigativeProjects(string adisease , int adealingValue ,int arewardValue, int ainvestigativeNum)
        { 
            diseaseName = adisease;
            dealingValue = adealingValue;
            rewardValue = arewardValue;
            investigativeNum = ainvestigativeNum;
        
        }
        // Define all investigative projects:
        static void Main(string[] args)
        { 
            investigativeProjects ALS = new investigativeProjects (,,,);
        }

       


    }

    class treatingProjects
    {
        public string sicknessName;
        public int dealingcost;
        public int reward;
        public int treatingNum;
  
        
        private treatingProjects (string asicknessName , int adealingcost ,int areward, int atreatingNum)
        { 

            sicknessName = asicknessName;
            dealingcost = adealingcost;
            reward = areward;
            treatingNum = atreatingNum;
        
        }

        // Define all investigative projects:
        static void Main(string[] args)
        { 
            treatingProjects ALS = new treatingProjects (,,,);
        
        }
      

    }
}
