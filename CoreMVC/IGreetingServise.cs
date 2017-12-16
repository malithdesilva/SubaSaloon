namespace CoreMVC
{
    public interface IGreetingServise
    {
        string GetGreeting();
        
    }
    public class Greeter : IGreetingServise
    {
        public string GetGreeting()
        {
            return "HI!";
        }
    }
}