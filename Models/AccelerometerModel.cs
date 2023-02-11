using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.Models
{
    /*
     DEFINITION: AccelerometerModel defines a mobile accelerometer.
     
     FIELDS: 
     private List<double> Data = new List<double>(); // data have come from Hub class
     private int Threshold = 20; // Threshold defines the minimum value.
    //The data in the list must be higher than the treshold
     private List<double> TruePicks = new List<double>();
     private List<double> FalsePicks = new List<double>();
     provate int AccelerometerSteps = 0;

     METHODS:
     private void FilterByTreshold(){}
     private void Analyze(){}
     public List<double> getTruePicks(){}
     public List<double> getFalsePicks(){}
     */
    class AccelerometerModel
    { 
        //constructor
        AccelerometerModel() { 
        
        }

        //fields
        private List<double> Data = new List<double>(); // data have come from Hub class
        private int Threshold = 20; // Threshold defines the minimum value.
                                    //The data in the list must be higher than the treshold
        private List<double> TruePicks = new List<double>();
        private List<double> FalsePicks = new List<double>();
        private int AccelerometerSteps = 0;

        //methods
        private void FilterByTreshold() { }
        private void Analyze() { }
        public List<double> getTruePicks => TruePicks;
        public List<double> getFalsePicks => FalsePicks;
    }
}
