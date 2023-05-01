Project part 1. First iteration of project, instantiates classes based off of parent class of animal, and uses a polymorphism example to prove understanding.
There is also a button on the windows form apps, connected to a polymorphism method to test changes, if working properly.

Project part 2. Home page has a button to read and write to a file, with repsective names for each. File is included, and reading
the file will read the test data, writing, will write an array of animal objects, with their repsective name and age,
and can then be read without closing the program using the same homepage/command window. All animals belong to an IAnimal interface
which delegates they all have the walk() and DisplayAnimalInfo(), with more methods to come. All functions of buttons inside of the 
home page are wrapped in try catches, to avoid program crashes.

Project part 3. Database was added. This was done using entity framework core migrations, so be sure to run "update-database" in the package manager
console upon opening application to add tables to local DB. A custome extenion was made to seed data in a seperate file, instead of cluttering the DbContext file.
There is a form added specifically to test the adding and search of database using linq queries, which can be opened from the main page, click the associated button.
Project part 2 has been unchanged temporarily, to allow you to properly grade those functions as they were, and will be udpated in next assignment.
