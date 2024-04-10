namespace PracticeAlgorithm;

public class DateFormatChallenges
{
    static string Solution(int seconds)
    {
        if (seconds == 0)
            return "now";
        int minutes = 0;
        int hours = 0;
        int days = 0;

        if (seconds >= 60)
        {
            minutes = seconds / 60;

            if (minutes >= 60)
            {
                hours = minutes / 60;

                if (hours >= 24)
                {
                    days = hours / 24;
                    hours %= 24;
                }

                minutes %= 60;
            }

            seconds %= 60;
        }

        string output = "";

        if (days > 0)
        {
            output += $"{days} day{(days > 1 ? "s" : "")} ";
        }

        if (hours > 0)
        {
            output += $"{hours} hour{(hours > 1 ? "s" : "")} ";
        }

        if (minutes > 0)
        {
            output += $"{minutes} minute{(minutes > 1 ? "s" : "")} ";
        }

        if (seconds > 0)
        {
            output += $"{seconds} second{(seconds > 1 ? "s" : "")}";
        }
        return output.Trim();
    }
}