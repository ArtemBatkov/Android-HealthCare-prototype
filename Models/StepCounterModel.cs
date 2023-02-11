using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.Models
{
    class StepCounterModel
    {
        /*
        DEFINITION: StepCounterModel describes a step counter sensor. 
        Every step counter works in the phone's hardware. It keeps data from 
        the last phones' reboot.

        Good news: It will help to do less process
        Bad news: We need to track and save the old data in DBs, and subtract it with the new one 
         
        FIELDS:
        private int StepCounter = 0; //step counter
        private DateTime TimeGrabber; 
        
        METHODS:
        public void onTimeHasCome(){}//get the old data from db and new from the sensor
        private void SaveToLocalDB(){}
        private void SaveToGlobalDB(){}

         */
    }
}
