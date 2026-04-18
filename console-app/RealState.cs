namespace console_app
{
    public class RealState
    {
        public string Address { get; set; }
        public int Price { get; set; }

        public int SquareFootage { get; set; }

        public int CalculatePricePerSquareFoot()
        {
            return Price / SquareFootage;
        }
    }
}