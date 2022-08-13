
# InfoTrack technical test

This is a project of getting ranks of your url in google search results.

## Design

API: .Net6, Clean Architecture, as no data saving function is required, so skipped the infrastructure layer. May be too complex for this app, but just wanted to demonstrate more skill like DI, Mediator, Unit test

UI: single page app developed by Angular 14

Please let me know if you have any questions. Thanks!

## Api Setup

Execute command 'dotnet run --project googlescrapper.api' under project file /GoogleScrapper.API 

You can test api on http://localhost:5000/swagger

## Unit Test

Execute command 'dotnet test' under file /GoogleScrapper.API 

(As Google search results may change, the unit test can be fail)

## UI Setup

Execute command 'npm install' and then 'ng serve' under file /GoogleScrapper.UI and test on http://localhost:4200/


