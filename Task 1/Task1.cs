// Instructions: Write a function (use template below to get started) that takes a list of integers and returns a list of only the positive even numbers, doubled. Add at least one error-handling condition

// For submission, commit and push the edited file to Github

// Start the function (Start of Template)

public class Task1
{
    public static List<int> GetDoubledPositiveEvens(List<object> listNumbers)
    {
        List<int> listFinal = new List<int>();

        // Go through each number in the list
        foreach (var item in listNumbers)
        {
            // Error handling: Check if item is a number
            if (!(item is int number))
            {
                // Skip non-integer values
                continue;
            }
            // Error handling: Check if the number is null (not necessary for int, but included for completeness)
            if (item == null)
            {
                // Skip null values
                continue;
            }
            // Check if the number is positive and even
            if (number > 0 && number % 2 == 0)
            {
                int twoTimes = number * 2; 

                // Double the number
                listFinal.Add(twoTimes); 

                // Add it to the final list
            }
        }

        // Return the list of doubled positive even numbers
        return listFinal;
    }

    // Example usage
    static void Main()
    {
        List<object> myNumbers = new List<object> { 1, 2, "hello", -4, 6, null, 8 };
        List<int> result = GetDoubledPositiveEvens(myNumbers);
        Console.WriteLine(string.Join(", ", result)); // Output: 4, 12, 16
    }
}