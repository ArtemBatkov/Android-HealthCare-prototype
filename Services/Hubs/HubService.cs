using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.Services.Hubs
{
    class HubService
    {
        /* 
        DEFINITION:
        HubService is a class which will accomplish the similar functionality as
        main() function in classic C#(C++,C) console apps.

        Some data (they can go from StepCounter, StepDetector, and Accelerometer) go to 
        the HubService. HubService will define which module these data should come in.
        
        Example: StepCounter can work asynchronously, plus outside the app (background)
        StepDetector should be inside of the Task as Accelerometer
        StepDetector must compute steps inside its class, but 
        as for the Accelerometer class, the hub should gather chuncks and transmit to its class

       

         */
    }
}
