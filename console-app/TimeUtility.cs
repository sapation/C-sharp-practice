namespace console_app
{
    public static class TimeUtility
    {
        public static void PrintCurrentTime() => Console.WriteLine(DateTime.Now.ToShortTimeString());
    }
}