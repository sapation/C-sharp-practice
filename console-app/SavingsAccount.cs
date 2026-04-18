namespace console_app
{
    public class SavingsAccount
    {
        public static double currentInterestRate;
        public static double bondRate;

        static SavingsAccount()
        {
            currentInterestRate = 0.4;
        }

        public static void AddBondRate()
        {
            currentInterestRate = bondRate + 0.1;
        }
    }
}