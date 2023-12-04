
namespace Demo2.UserComponents
{
    public class UserService
    {
        public  List<User> GetUser()
        {
            return new List<User>()
            {
                new User () { PhoneNumber = "08137970189"},
                new User () { PhoneNumber = "09153213891"}
            };
        }
    }
}