namespace E_commerce.Models;

public class SiteProvider : BaseProvider
{
    public SiteProvider(IConfiguration conf) : base(conf)
    {}

    CategoryRepository? category;
    public CategoryRepository Category => category ??= new CategoryRepository(Connection);

    ProductRepository? product;
    public ProductRepository Product => product ??= new ProductRepository(Connection);
}