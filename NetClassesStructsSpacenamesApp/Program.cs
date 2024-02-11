using NetClassesStructsSpacenamesApp;

Employee employee = new Employee();
employee.name = "Bobby";
employee.age = 25;
Employee bob = employee;

employee.Show();

bob.name = "Noname";
employee.Show();



Employee joe = new Employee() { name = "Joe", age = 31 };

var leo = new Employee() { name = "Leo", age = 28 };
Employee tom = new() { name = "Tom", age = 19 };

Employee Jim = new("Jim", 22);

BirthDate date = new BirthDate() 
                    { 
                        day = 5, 
                        month = 9, 
                        year = 2019 
                    };
date.Show();

BirthDate date2 = date with { day = 30 };
//date2.day = 30;

date.Show();
date2.Show();