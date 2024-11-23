namespace E_commerce.Models;

public class Supplier {
    public short SupplierId { get; set; }
    public string CompanyName { get; set; } = null!;
    public string Logo { get; set; } = null!;
    public string ContactName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public int Phone { get; set; }
    public string Address { get; set; } = null!;
    public string Description { get; set; } = null!;
}
/*
	[SupplierId] [varchar](2) NOT NULL,
	[CompanyName] [nvarchar](64) NOT NULL,
	[Logo] [VARCHAR](32) NOT NULL,
	[ContactName] [nvarchar](64) NULL,
	[Email] [nvarchar](64) NOT NULL,
	[Phone] [nvarchar](16) NULL,
	[Address] [nvarchar](64) NULL,
	[Description] [nvarchar](max) NULL
*/