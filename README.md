# HealthCare
## Definition: HealthCare app has the main goal to help people of changing their life and habits.

### The architecture of the app: 
#### Level 1 -- top
##### Definition: Each component of the app is determined in a specific folder: Models, Views, ViewModels or Services.

#### Level 2 -- middle
##### Definition: The idea of how it should work on programming layer
##### Schema:
######  &emsp; Services:   HubService is a class that some data comes from a sensor or/and some sensors. To understand it, imagine the main() function in C# console app. The HubService determines in what place (module) these data should be redirected. <br />WebQR service works with the internet by fetching some data.

###### Models: HubModel relates to the HubService; StepDetectorModel describes a step detector sensor of the phone; StepCounter describes a step counter sensor of the phone; AccelerometerModel describes an accelerometer sensor of the phone; 

###### ViewModels: a link between the model and the page. It is a kind of controller that interacts with the page. 

###### Views: a view means a page. The page is a screen where some UI elements may be seen.

#### Level 3 -- bottom
##### Definition: Level 3 Describes the hardware level.
###### Sensors: StepDetector, StepCounter, and Accelerometer.
###### Preferences: StepCounter is the best sensor, because it works outside the app, plus it works in the hardware layer, so it doesn't load the system.
###### Alternatives: Accelerometer can be used if there are any others sensors. Accelerometer doesn't know anything about the steps, it just fetches 3 coordinates X,Y,Z. Knowing these data the magnitude can be computed. Each value of magnitude can be stored in a temporary array, and then analyzed. 


## Schema can be presented as the following:
![Components relationship](https://user-images.githubusercontent.com/110242091/219827237-7dee3a80-1deb-429a-8aeb-e70641fbcf94.jpg)
