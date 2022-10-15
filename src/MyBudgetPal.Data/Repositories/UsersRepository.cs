using Dapper;
using MyBudgetPal.Data.Interfaces;
using MyBudgetPal.Data.Models;
using TodoApp.Api;

namespace MyBudgetPal.Data.Repositories
{
  public class UsersRepository : IUserRepository
  {
    public UsersRepository(DbContext db)
    {
      _db = db;
    }
    private readonly DbContext _db;
    public async Task<UserDataModel> GetUserByUsername(string username)
    {
      using (var connection = _db.CreateConnection())
      {
        return await connection.QueryFirstOrDefaultAsync<UserDataModel>(@"
          SELECT * FROM MY_BUDGET_USERS
          WHERE USERNAME = @username", new { username }
        ).ConfigureAwait(false);
      }
    }
  }
}