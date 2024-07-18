using BlazorSQLServerWebApp.Shared.Models;

namespace BlazorSQLServerWebApp.Server.Interfaces
{
    public interface IUser
    {
        public List<User> GetUserDetails();
        public void AddUser(User user);
        public void UpdateUserDetails(User user);
        public User GetUserData(int id);
    }
}
