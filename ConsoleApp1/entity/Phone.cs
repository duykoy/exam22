namespace ConsoleApp1.entity
{
    public class Phone : Product
    
    {
        public override double computeTax()
        {
            return _price * 10 / 100;
        }    
    }
}