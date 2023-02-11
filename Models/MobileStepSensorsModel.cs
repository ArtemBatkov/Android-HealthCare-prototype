using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.Models
{
    /*
     DEFINITION: MobileStepSensorsModel is a class that will define the model 
    of the mobiles' sensors
    
     
    FIELDS: 
    private double accelerometer_frequency = 50d; //defines the frequency of the accelerometer 
    private string accelerometer_regime = "standard"; //defines the working regim of the accelerometer
    public  List<bool> ListOfSensors = new List<bool>{false,false,false}; //defines the list of allowed sensors
    private double accelerometer_period = 1/accelerometer_frequency;


    METHODS: 
    ONLY GETS AND SETS METHODS. MINIMUM OF LOGIC.
   */
    class MobileStepSensorsModel
    {
        //constructor
        public MobileStepSensorsModel() { 
        }

        //fields
        private double accelerometer_frequency = 50d; //defines the frequency of the accelerometer 
        private string accelerometer_regime = "standard"; //defines the working regim of the accelerometer
        private List<bool> ListOfSensors = new List<bool> { false, false, false }; //defines the list of allowed sensors
        //Accelerometer, Step-detector, Step-counter

        //methods
        public double getAccelerometerFrequency() => accelerometer_frequency;
        public double getAccelerometerPeriod() => 1 / accelerometer_frequency;
        public List<bool> getListOfSensors => ListOfSensors;
    }

    
}
