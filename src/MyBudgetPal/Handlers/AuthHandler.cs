using MyBudgetPal.Data.Interfaces;
using MyBudgetPal.Data.Models;
using MyBudgetPal.Interfaces;
using MyBudgetPal.Models;

namespace MyBudgetPal.Handlers
{
  public class AuthHandler : IAuthHandler
  {
    public AuthHandler(
      IAuthRepository authRepository,
      IUserRepository userRepository)
    {
      _authRepository = authRepository;
      _userRepository = userRepository;
    }
    private readonly IAuthRepository _authRepository;
    private readonly IUserRepository _userRepository;

    public async Task<HandlerResultModel<Guid>> CreateNewUser(NewUserModel model)
    {
        var existingUser = await _userRepository.GetUserByUsername(model.Username.ToString()).ConfigureAwait(false);
        if (existingUser != null)
        {
          return new HandlerResultModel<Guid>()
          {
            IsSuccessful = false,
            Message = "Username already exists."
          };
        }
        try
        {
          var mappedUser = new NewUserDataModel()
          {
              ID = Guid.NewGuid(),
              DATE_CREATED = DateTime.UtcNow,
              ACCESS_CODE = Guid.NewGuid(),
              USERNAME = model.Username,
              EMAIL = model.Email
          };
          await _authRepository.CreateNewUser(mappedUser).ConfigureAwait(false);
          return new HandlerResultModel<Guid>()
          {
            Data = mappedUser.ACCESS_CODE,
            IsSuccessful = true,
            Message = "Successfully created new user."
          };
        }
        catch (Exception e)
        {
          return new HandlerResultModel<Guid>()
          {
            IsSuccessful = false,
            Message = e.StackTrace!
          };
        }
    }
  }
}