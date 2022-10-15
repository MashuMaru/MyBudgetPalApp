using Dapper;
using MyBudgetPal.Data.Interfaces;
using MyBudgetPal.Data.Models;
using TodoApp.Api;

namespace MyBudgetPal.Data.Repositories
{
  public class AuthRepository : IAuthRepository
  {
    public AuthRepository(DbContext db)
    {
      _db = db;
    }
    private readonly DbContext _db;

    public async Task CreateNewUser(NewUserDataModel model)
    {
      using (var connection = _db.CreateConnection())
      {
        await connection.ExecuteAsync(@"
          INSERT INTO MY_BUDGET_USERS (
            ID, 
            DATE_CREATED, 
            ACCESS_CODE, 
            USERNAME, 
            EMAIL
            ) VALUES (
            @ID, 
            @DATE_CREATED, 
            @ACCESS_CODE, 
            @USERNAME, 
            @EMAIL)", model
        ).ConfigureAwait(false);
      }
    }
  }
}