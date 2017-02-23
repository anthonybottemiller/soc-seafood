#soc-seafood

#####This project leverages asp.net, SQL, and entity framework with authentication to manage a newsletter list

#####By Anthony J Bottemiller - 2-22-2016

##Description
This project will provide Son Of Cod Seafood with a web application that provides Managment features for a newsletter

##Technologies Used
* HTML
* CSS
* BOOTSTRAP
* C#
* .NET Core
* ASP.NET MVC
* Entity Framework
* Razor
* SQL
* Microsoft Identity
* xUnit

##Requirements
* Modern Web Browser
* .NET CORE
* SQL Server
* Internet Access

##Style Inspiration
The style of the project was inspired by [Pacific Seafood](https://www.pacseafood.com/)

##Admin Seeding
* If you have SSMS installed simply double click on the "SeedAdmin" script at the root of the repository and execute.
* Otherwise navigate to the root of the repository and execute 'sqlcmd -S "(localdb)\mssqllocaldb" -E -i SeedAdmin.sql'

##Installation
* Clone repository
* Using command line change working directory to cloned repository
* Execute command "cd /src/SOCseafood"
* Execute command "dotnet restore" in order to resolve project dependencies
* Execute command "dotnet ef migrations add Initial"
* Execute command "dotnet ef database update"
* Seed Admin if desired
* Execute command "dotnet run"
* Navigate to [webserver](http://localhost:5000) using your favorite browser

##Legal
Copyright (c) 2017 Anthony J Bottemiller

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.