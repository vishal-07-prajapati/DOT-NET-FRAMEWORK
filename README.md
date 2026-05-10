-- this is how you can add any repo in git and manage code.

-- replace test with you repo name
echo "# test" >> README.md

git init

git add README.md

git commit -m "first commit"

git branch -M main

git remote add origin https://github.com/vishal-07-prajapati/test.git

git push -u origin main

------
EmployeeManagement.API
│
├── Controllers
│   └── EmployeeController.cs
│
├── Models
│   ├── Employee.cs
│   └── Department.cs
│
├── DTOs
│   ├── EmployeeDto.cs
│   ├── CreateEmployeeDto.cs
│   └── UpdateEmployeeDto.cs
│
├── Interfaces
│   ├── IGenericRepository.cs
│   ├── IEmployeeRepository.cs
│   └── IEmployeeService.cs
│
├── Repositories
│   ├── GenericRepository.cs
│   └── EmployeeRepository.cs
│
├── Services
│   └── EmployeeService.cs
│
├── Data
│   └── AppDbContext.cs
│
├── Extensions
│   └── QueryableExtensions.cs
│
├── Validators
│   └── EmployeeValidator.cs
│
├── Middleware
│   └── ExceptionMiddleware.cs
│
├── appsettings.json
├── Program.cs
└── EmployeeManagement.API.csproj

-----

connection string:

<connectionStrings>
  <add name="DefaultConnection"
       connectionString="Server=.;Database=EmployeeDb;Trusted_Connection=True;"
       providerName="System.Data.SqlClient" />
</connectionStrings
connectionString="Server=.;Database=EmployeeDb;User Id=sa;Password=123;"

{
  "ConnectionStrings": {
    "DefaultConnection":
      "Server=.;Database=EmployeeDb;Trusted_Connection=True;TrustServerCertificate=True"
  }
}
"DefaultConnection":
"Server=.;Database=EmployeeDb;User Id=sa;Password=123;TrustServerCertificate=True"

