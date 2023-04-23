## Musala Project Tests

### Description
The following project includes automated UI tests for [Musala Soft website](https://www.musala.com/ "Musala Soft") . 
The tests are written in C# using **Selenium** framework and **NUnit** framework.  
The test are separated in different classes depending on the page they are for. Some of the provided test cases are separated in smaller tests depending on what they need to verify.  
For easier maintenance it is used POM, Driver Factory(_DriverContext_) and different classes for each object.  
For the reports of the test it is used ExtentReports. After the tests are run you will find the file with the reports in bin/net6/results folder of the project.  

### Installation
In order for the tests to run you need to have the following:
* Chrome browser
* Firefox browser

***

**Note**:  The project will work best on Chrome brwoser and on **2560X1140** resolution (improvements on this can be added).