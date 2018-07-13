namespace ConsoleApp1.entity
{
    public abstract class Product
    {
        public int _id;
        public string _name;
        public int _price;

        public Product()
        {
        }

        public Product(int id, string name, int price)
        {
            _id = id;
            _name = name;
            _price = price;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Price
        {
            get => _price;
            set => _price = value;
        }

        public abstract double computeTax();
    }
}