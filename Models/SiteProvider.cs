namespace E_commerce.Models;

public class SiteProvider : BaseProvider
{
    public SiteProvider(IConfiguration conf) : base(conf)
    {}

    CategoryRepository? category;
    public CategoryRepository Category => category ??= new CategoryRepository(Connection);

    SubCategoryRepository? subCategory;
    public SubCategoryRepository SubCategory => subCategory ??= new SubCategoryRepository(Connection);
}