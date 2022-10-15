using MyBudgetPal.Models;

namespace MyBudgetPal.Interfaces
{
    public interface IAuthHandler
    {
         Task <HandlerResultModel<Guid>> CreateNewUser(NewUserModel model);
    }
}