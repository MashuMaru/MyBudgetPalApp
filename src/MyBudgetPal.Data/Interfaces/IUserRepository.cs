using MyBudgetPal.Data.Models;

namespace MyBudgetPal.Data.Interfaces
{
    public interface IAuthRepository
    {
         Task CreateNewUser(NewUserDataModel model);
    }
}