using System.Data;
using Dapper;

namespace E_commerce.Models;

public class CategoryRepository : BaseRepository{
    public CategoryRepository(IDbConnection context) : base(context) { }

    public IEnumerable<Category> GetCategories(){
        return connection.Query<Category>("Select * from Category");
    }

        public Category? GetCategory(short id){
        string sql = "SELECT * FROM Category WHERE CategoryId = @id";
        return connection.QuerySingleOrDefault<Category>(sql, new{id});
    }
}