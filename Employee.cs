// Define a class named Employee
public class Employee
{
    // Property to store the employee's unique ID
    public int Id { get; set; }

    // Property to store the employee's first name
    public string FirstName { get; set; }

    // Property to store the employee's last name
    public string LastName { get; set; }

    // Overload the == operator
    // This compares two Employee objects by their Id property
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // If both objects are null, they are considered equal
        if (ReferenceEquals(emp1, emp2))
            return true;

        // If one object is null and the other is not, they are not equal
        if (emp1 is null || emp2 is null)
            return false;

        // Compare the Id values of both Employee objects
        return emp1.Id == emp2.Id;
    }

    // Overload the != operator
    // This returns the opposite result of ==
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }

    // Override Equals so it matches the overloaded operators
    public override bool Equals(object obj)
    {
        // Check if the object is an Employee
        if (obj is Employee other)
        {
            // Compare the Id values
            return this.Id == other.Id;
        }

        return false;
    }

    // Override GetHashCode when Equals is overridden
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}
