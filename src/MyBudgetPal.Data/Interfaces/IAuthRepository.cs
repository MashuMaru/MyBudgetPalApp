using MyBudgetPal.Data.Models;

namespace MyBudgetPal.Data.Interfaces
{
    public interface IUserRepository
    {
         Task<UserDataModel> GetUserByUsername(string username);
    }
}