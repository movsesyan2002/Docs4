// Task 8: E-Commerce Product System
// Task: Create a class Product with:
// Fields name, price, and stockQuantity.
// Add a constructor that uses this to differentiate between parameters and fields.
// In Main(), create a product and display its details.

class Product
{
    private string name;
    private int price;
    private int stockQuantity;

    public Product(string name, int price, int stockQuantity)
    {
        this.name = name;
        this.price = price;
        this.stockQuantity = stockQuantity;
    }

    public string Name
    {
        get { return name; }
    }

    public int Price
    {
        get { return price; }
    }

    public int StockQuantity
    {
        get { return stockQuantity; }
    }

}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter product name:  ");
        string? productname = Console.ReadLine();
        
        Console.Write("Enter product price:  ");
        int productprice;
        
        if (int.TryParse(Console.ReadLine(),out productprice) == false) 
        {
            Console.WriteLine("You enter invalid argument");
        }

        Console.Write("Enter product stock quantity");
        int productquantity;
        if (int.TryParse(Console.ReadLine(),out productquantity) == false) 
        {
            Console.WriteLine("You enter invalid argument");
        }

        Product product = new Product(productname,productprice,productquantity);
        Console.WriteLine($"The product name {product.Name}\nPrice {product.Price}\nStock quantity {product.StockQuantity}");

    }
}