namespace MyBudgetPal.Interfaces
{
    public class IAuthHandler
    {
        HandlerResultModel<Guid> CreateNewUser(NewUserModel model);
    }
}