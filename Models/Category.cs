namespace E_commerce.Models;

public class Category {
    public short CategoryId {get; set;}
    public string CategoryName {get; set;} = null!; 
    public string SubCategoryName { get; set; } = null!;
}