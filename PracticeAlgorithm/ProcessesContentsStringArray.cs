namespace PracticeAlgorithm;

public class ProcessesContentsStringArray
{
    // your solution must use the following string array to represent the input to your coding logic:
    // string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
    // Your solution must declare an integer variable named periodLocation that can be used to hold the location of the period character within a string.
    //
    // Your solution must include an outer foreach or for loop that can be used to process each string element in the array. The string variable that you'll process inside the loops should be named myString.
    //
    //     In the outer loop, your solution must use the IndexOf() method of the String class to get the location of the first period character in the myString variable. The method call should be similar to: myString.IndexOf("."). If there's no period character in the string, a value of -1 will be returned.
    //
    //     Your solution must include an inner do-while or while loop that can be used to process the myString variable.
    //
    //     In the inner loop, your solution must extract and display (write to the console) each sentence that is contained in each of the strings that are processed.
    //
    //     In the inner loop, your solution must not display the period character.
    //
    //     In the inner loop, your solution must use the Remove(), Substring(), and TrimStart() methods to process the string information.
    //
    
    // the output is as follows
    // I like pizza
    // I like roast chicken
    // I like salad
    // I like all three of the menu choices

    [Fact]
    public Task PrintProcessesContentsStringArray()
    {
        string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
        int stringsCount = myStrings.Length;

        string myString = "";
        int periodLocation = 0;

        for (int i = 0; i < stringsCount; i++)
        {
            myString = myStrings[i];
            periodLocation = myString.IndexOf(".");

            string mySentence;

            // extract sentences from each string and display them one at a time
            while (periodLocation != -1)
            {

                // first sentence is the string value to the left of the period location
                mySentence = myString.Remove(periodLocation);

                // the remainder of myString is the string value to the right of the location
                myString = myString.Substring(periodLocation + 1);

                // remove any leading white-space from myString
                myString = myString.TrimStart();

                // update the comma location and increment the counter
                periodLocation = myString.IndexOf(".");

                Console.WriteLine(mySentence);
            }
 
            mySentence = myString.Trim();
            Console.WriteLine(mySentence);
        }
        return Task.CompletedTask;
    }
}