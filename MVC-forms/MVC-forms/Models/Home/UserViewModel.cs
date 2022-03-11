namespace MVC_forms.Models.Home
{
    public class UserViewModel
    {
        public UserViewModel(User user)
        {
            User = user;
        }
        public User User { get; set; }
    }
}
