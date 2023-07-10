# ArcV
Contains a solution for creation and manipulation of wind-related classes, including towers, sensors and measurements

1) Proposal of a C# class/struct architecture design that hold all metadata and data for wind speed and wind direction sensors on a met tower.

Three classes were proposed:
•	Area – can contain a list of towers
•	MetTower – is associated to an area and can contain sensors
•	Sensor – is located at a given height in a given tower
•	Measurement – holds measurements data and metadata, and is associated to a sensor

Constructor methods were created with a design that permits:
•	Default instantiation of empty Areas, MetTowers and Sensors, allowing initialization and use in other functions; 
whereas measurements do not have default instantiation and should carry parameters in their construction.

•	In case parameters are provided in the instantiation of Area(), MetTower() or Sensor(), a check is made to make sure 
there are no objects with the provided ID. If ID is not yet existent, object is created and added to its respective global list.
These lists were designed just for the exercise purpose, but in real life, this process would be part of an API interface to a database.
   
2) Proposal of functions in C# that calculates and returns the average wind speed over a specified time period. 

Three functions were created to take average speed:

getAverageSpeedForTowerOverTime
•	Calls getMeasurementsByTower to select measurements by towerID  
•	Calls getAverageOverTime to get average speed

getAverageSpeedForAreaOverTime
•	Calls getMeasurementsByArea to select measurements by areaID  
•	Calls getAverageOverTime to get average speed

getAverageOverTime
•	gets average speed of a given set of measurements. It is very useful, because it is generic enough to be called in other functions that 
select the desired measurements, e.g. by area, height, sensors, etc. 
•	Other functions already existent in the code could be combined with getAverageOverTime to get further average speeds, e,g:
--> getMeasurementsFromSensorList
--> getMeasurementsFromTowersList

•	It is worth noting that taking average of averages in a period is not the same as taking the average over that period.
For taking exact average, we need the entire timeseries of the period. Here we assume that the 10min-data aggregation is good enough for our purposes.

3)	Proposal of function in C# that calculates and returns the average wind shear power law exponent. 

The wind shear exponent can be easily gotten from log(h1/h0)/log(v1/v0). However, l assumed I have a new area with measurements and I still don’t know 
anything about the area, including h1, h0, v1, and v0. Hence, I created the following functions:

•	getHeightAndSpeedsDict – from the given list of measurements, it provides a dictionary with a list of speed measurements for each height. 
•	getHeightAndSensorsDict - it provides a dictionary with a list of sensor measurements for each height

The output of getHeightAndSpeedsDict can also be useful for other purposes, like creating graphs and comparisons of heights and windspeeds relations. 
Also, since it allows evaluating generic measurement sets, it can be useful, for example, if in the future we need to get this exponent in a subset 
of towers/ sensors in the same area or adjacent areas, to further compare their height/speed relation. To achieve this, it would only be needed to filter 
the proper measurements pertaining to the selected criteria before calling the dictionary and perform the same operations to get h1, v1, h2 and v2.

It is worth mentioning that it is not efficient to create these dictionaries every time. The idea is to create once, and, upon addition of new 
measurements / sensors, they would go straight to the correct position in the already created dictionary. Also, considering all measurements of 
all times would be time consuming; hence it is worth considering a filter by time. Nevertheless, these functions and operations were created
to demonstrate a thought process over the data, and also the manipulation of structures, classes, dicts, lists, etc. In reality, those measurements
would be in a database and this kind of filtering and further processing could be done with a combination of SQL statements and/or PL/SQL.
