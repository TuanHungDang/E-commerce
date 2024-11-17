using System.Data;
using Dapper;

namespace E_commerce.Models;

public class SubCategoryRepository : BaseRepository
{
    public SubCategoryRepository(IDbConnection context) : base(context)
    {}

    public IEnumerable<SubCategory> GetSubCategories(){
        return connection.Query<SubCategory>("Select * from SubCategory");
    }
}