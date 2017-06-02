# RecruitmentApp

CRUD module of Customer data with the following fields:
- Name
- Surname
- Telephone Number
- Address

To run project you need Visual Studio Community 2015 or compatible.

Customer CRUD module is implemented as a part of ASP.NET MVC 5 application.

My choices and explanations
	1. Name, Surname, Telephone Number, Address fields are required and have length restrictions for better query performance
	2. I choose ASP.NET MVC -  because of separation of concerns, good for team work, and testing
	3. I assumed data source is MSSQL Server - for development LocalDB in App_Data
	4. I choose EF Code First - because it uses POCO so EF could be easy exchanged
	5. I created layers - DAL -> Service -> Controller -> View
	6. I choose DI and Unity because Service and Controller are loosely coupled (good for service testing and easy service exchange)
	
What would I do next:
	1. Create tests for Service Layer
	2. Create separate libraries for Model, DAL, and Service


