
# InfoTrack technical test

This is a project of getting ranks of your url in google search results. It includes baisc feature and extra feature like search history. I wish I could have more time to add other search engine feature.

## Design

DB: SQL Server Express

API: .Net6, hexagonal architecture, splited in 4 layers. It may be too complex for this app, but just wanted to demonstrate more skill like DI, Mediator, Unit test

UI: single page app developed by Angular 14

Please let me know if you have any questions. Thanks!

## DB Setup

Use Visual Studio PM Console, go to poject GoogleScrapper.Infrastructure and execute command 'update-database'

## Api Setup

Execute command 'dotnet run --project googlescrapper.api' under Visual Studio Console 

You can test api on http://localhost:5000/swagger

## Unit Test

Execute command 'dotnet test' under Visual Studio Console

(As Google search results may change, the unit test can be fail)

## UI Setup

Execute command 'npm install' and then 'ng serve' under file /GoogleScrapper.UI and test on http://localhost:4200/


