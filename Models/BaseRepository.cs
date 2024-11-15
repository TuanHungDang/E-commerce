using System.Data;

namespace E_commerce.Models;

public abstract class BaseRepository{
    protected IDbConnection connection;

    public BaseRepository(IDbConnection cn){
        connection = cn;
    }
}