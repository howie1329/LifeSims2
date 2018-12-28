using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSims2.Data
{
    class Disease
    {
        public string DiseaseName { get; set; }
        public int DiseaseEffect { get; set; }
        public string PlayerHealthState { get; set; }

        enum HealthState
        {
            Healthy = 0,
            Sick = 5,
            Dying = 10
        }

       
        public Disease[] CreateDiseases()
        {
            Disease[] DiseaseList = new Disease[7];
            DiseaseList[0] = new Disease();
            DiseaseList[0].DiseaseName = "Healthy";
            DiseaseList[0].DiseaseEffect = 0;
            DiseaseList[0].PlayerHealthState = Enum.GetName(typeof(HealthState),DiseaseList[0].DiseaseEffect);
            DiseaseList[1] = new Disease();
            DiseaseList[1].DiseaseName = "Flu";
            DiseaseList[1].DiseaseEffect = 5;
            DiseaseList[1].PlayerHealthState = Enum.GetName(typeof(HealthState), DiseaseList[1].DiseaseEffect);
            DiseaseList[2] = new Disease();
            DiseaseList[2].DiseaseName = "AIDS";
            DiseaseList[2].DiseaseEffect = 10;
            DiseaseList[2].PlayerHealthState = Enum.GetName(typeof(HealthState), DiseaseList[2].DiseaseEffect);
            DiseaseList[3] = new Disease();
            DiseaseList[3].DiseaseName = "Common Cold";
            DiseaseList[3].DiseaseEffect = 2;
            DiseaseList[3].PlayerHealthState = Enum.GetName(typeof(HealthState), 5);
            DiseaseList[4] = new Disease();
            DiseaseList[4].DiseaseName = "Whooping Cough";
            DiseaseList[4].DiseaseEffect = 3;
            DiseaseList[4].PlayerHealthState = Enum.GetName(typeof(HealthState), 5);
            DiseaseList[5] = new Disease();
            DiseaseList[5].DiseaseName = "Cancer";
            DiseaseList[5].DiseaseEffect = 25;
            DiseaseList[5].PlayerHealthState = Enum.GetName(typeof(HealthState), 10);
            DiseaseList[6] = new Disease();
            DiseaseList[6].DiseaseName = "Sore Throat";
            DiseaseList[6].DiseaseEffect = 4;
            DiseaseList[6].PlayerHealthState = Enum.GetName(typeof(HealthState), 5);

            return DiseaseList;
        }
    }
}
