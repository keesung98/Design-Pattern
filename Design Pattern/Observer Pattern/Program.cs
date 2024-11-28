using Observer_Pattern.Models;

class Program
{
    static void Main(string[] args)
    {
        Product product = new("게임 콘솔");
        User user1 = new("Kane", product);
        User user2 = new("Big show", product);

        Console.WriteLine("처음 제품 상태: " + product.ProductAvailability);
        product.ProductAvailability = "In Stock";

        product.ProductAvailability = "close to being sold out";

        user1.ExitObserver(product);

        product.ProductAvailability = "ReStore new Items";
    }
}