# Coding-Challenge

This project is built with ASP.NET Core 5.0 and Angular 11

#Getting Started
To start the front end application, run the following while in the AngularProject directory: ng serve
To start the back end services, open the CalculatorWebApi.sln and select Run Without Debugging from Microsoft Visual Studio. 

#How It Works
There are 2 text boxes on this calculator, that will only accept numbers 0-9. If you would like to create a sum, you simply plug in the desired numbers in the boxes and click on the Add button. This will display the result in the middle of the calculator. Alternatively if you would like to find the quotient of a number, plug the dividend into the left box, the divisor into the right box and click Divide. 

#Known Issues
- The AvailableOperations button is not functional, as it appears that there is bug in parsing a string from the API to JSON. 
