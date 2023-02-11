using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.Models
{

    class Hub
    {
        /*
        DEFINITION: Hub is a class that will define some properties of the hub.
        Hub represents a "bridge" between the data comming from the sensors and 
        each a specific analyzer that will decide how to analyze these data.
        
    
     
        FIELDS: 
        private int WindowTimeAnalyse = 10_000; //10s or 10 000 ms
        private double ClockPeriod = 1/50*1000; // takes from MobileStepSensor class
        private int MaxChuncks = (int) ((double) WindowTimeAnalyse/ ClockPeriod);
        //Quantity of chuncks: if the time analyse is 10 sec (or 10 000ms), and each
        //peace of sensors' data comes every 1/50(or 20 ms) that means we are expecting
        // 10 000 / 20 = 500 chincks (for 10 sec) -- it is an array length also
        private List<double> AccelerometerData() = new List<double>(MaxChuncks);


        METHODS: 
        get/set for some properties + logic stuff(relink to specific module)
    
        private void PassDataToAccelerometerModule();
        private void PassDataToStepDetectorModule();
        private void PassDataToStepCounterModule();


       */

        //constructor
        public Hub()
        {

        }

        //fields
        private static int WindowTimeAnalyse = 10_000; //10s or 10 000 ms
        private static double ClockPeriod = 1 / 50 * 1000; // takes from MobileStepSensor class
        private int MaxChuncks = (int)((double)WindowTimeAnalyse / ClockPeriod);

        //methods
        private void PassDataToAccelerometerModule() { }
        private void PassDataToStepDetectorModule() { }
        private void PassDataToStepCounterModule() { }
    }
}
