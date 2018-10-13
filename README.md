INTRO

Our application provides health professionals with timely and usable data about their patients, and enables simple and effective meal 
logging for people looking to lose weight and lead a healthier life.

ABOUT

Nutrition logger for tracking food consumption, quantity and quality of consumed food and beverages per meal and place of consumption.

Each client/patient inputs type and amount of consumed food per meal and a place of consumption during his or her treatment by nutritionist.

Nutritionist has access to every information inputed by clients, statistical data and notifications in case a client/patient does not input 
required information regarding meals within 24 hours after the last input. 

TECHNOLOGIES USED

Initially the backend of the application will be written in C#, with SQL database connected with Dapper. Frontend will be made with ASP.NET Core MVC. 

BASIC PROJECT STRUCTURE 

Vitalic Database Project 	- will in future be used to manipulate, create, alter SQL database, stored procedures, seed database with data...

VitalicDtoModel 			- will be used in future to create Dto classes to be used by other projects.
		
VitalicModel 				- classes here will represent SQL tables.
		
Vitalic Resources 			- which will contain shared files, Resix files, images, fonts and so on, for various front-end technologies.
		
Vitalic.UI 					- ASP.NET Core MVC project
