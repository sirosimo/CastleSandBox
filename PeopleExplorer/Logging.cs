namespace PeopleExplorer;

public class Logging : ILogging{
    public void LogMessage(string message){
        Console.WriteLine(message);
    } }