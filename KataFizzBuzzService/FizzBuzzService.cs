namespace KataFizzBuzzService;
public class FizzBuzzService
{

    public string Run()
    {
        string result = string.Empty;
        Enumerable.Range(1, 100).ToList().ForEach(e => result += this.MakeLine(e));
        return result;
    }

    public string MakeLine(int number)
    {
        if (number % 15 == 0)
        {
            return "FizzBuzz";
        }

        if (number % 3 == 0)
        {
            return "Fizz";
        }

        if (number % 5 == 0)
        {
            return "Buzz";
        }

        return number.ToString();
    }
}
