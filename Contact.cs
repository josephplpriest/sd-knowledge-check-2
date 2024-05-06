namespace items;

public class Contact
{
    public string ?FirstName { get; set;}
    public string ?LastName { get; set;}
    public int Age { get; set;}

    public override string ToString()
    {
        return $"FirstName:{FirstName}, LastName:{LastName}, Age:{Age}";
    }

}