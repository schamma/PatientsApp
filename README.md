This project is divided into two components:
  
  1. Patientsapp.Server is .NET core 
  
  2. Patientsapp.client is Angular

It's configured for SQLite.

To set up the project:
Clone the repository

For Angular:

navigate to the Patientsapp.client solution
enter the following in the terminal:
    
    npm install
    
    ng serve

For .NET:

Install dependencies and database
navigate to the Patientsapp.Server project and enter the following in the terminal:
    
    dotnet restore

Run the project:
    
    dotnet run

Run the solution in localhost, my swagger was at the following URL: https://localhost:2190/swagger/index.html

The database should populate with the seeded data. Here is a sample username and password that should work:

Username: bmiller

Password: password
