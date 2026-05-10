// Create the first Employee object
Employee employee1 = new Employee();

// Assign values to the first employee's properties
employee1.Id = 1;
employee1.FirstName = "Nida";
employee1.LastName = "Khan";

// Create the second Employee object
Employee employee2 = new Employee();

// Assign values to the second employee's properties
employee2.Id = 1;
employee2.FirstName = "John";
employee2.LastName = "Smith";

// Compare the two Employee objects using the overloaded == operator
bool areEqual = employee1 == employee2;

// Display the comparison result
Console.WriteLine("Are the two employees equal? " + areEqual);

// Compare the two Employee objects using the overloaded != operator
bool areNotEqual = employee1 != employee2;

// Display the comparison result
Console.WriteLine("Are the two employees not equal? " + areNotEqual);
