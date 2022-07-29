# TwistedPairEF

This app is a redesigning of my app for the software development 1 course. Originally it was a console app that would give the user which colored pair to use in your phone installation. For reference, when an installer is at the pole or the pedastal where the house line connects to the main line, they have to find which pair to connect to the house's line. Typically this is a 25 pair line. This updated version uses EF Core with MVC and API to allow users to add, edit, and delete pairs as they see fit, up to 600.

- This app was created in VS2022 with .NET 6.0
- To run the app, once you open the solution you will need to add-migration, then update-database in the package manager console before starting it. This will seed the initial 26 pairs. The original 25 from the first app, then a 26th pair that shows the binder colors matching the pattern of the pair colors.
- A user can interact with the app through both the MVC page, and also through the API, with Postman for instance. 

## Feature List
- "Create an additional class which inherits one or more properties from its parent", ReadColors.cs inherits from Colors.cs
- "Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program", There is a List<Colors> used to populate the application
- "Read data from an external file, such as text, JSON, CSV, etc and use that data in your application", I'm reading from coloredPairs.json and passing it to ApplicationDbContext.cs to seed the database on the first load of the application
