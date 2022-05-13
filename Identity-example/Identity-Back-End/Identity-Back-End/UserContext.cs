using Identity_Back_End.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Identity_Back_End
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Todo> Todos { get; set; }

        public async Task<User> UpsertGithubUser(GithubUser githubUser, string token)
        {
            var user = await Users.FirstOrDefaultAsync(user => user.Email == githubUser.email);
            if (user == null)
            {
                user = new User();
                user.UserName = githubUser.login;
                user.Email = githubUser.email;
                user.Authority = Authority.Github;
                user.Token = token;
                user = (await Users.AddAsync(user)).Entity;
            } 
            else
            {
                user.Token = token;
                Users.Update(user);
            }

            await SaveChangesAsync();

            return user;
        }

        public async Task<User> GetUser(int id)
        {
           return await Users.FindAsync(id);
        }

        public async Task<User> UpdateUserToken(int id, string token)
        {
            var user = await GetUser(id);
            user.Token = token;
            Users.Update(user);
            await SaveChangesAsync();
            return user;
        }

        public async Task Logout(int id)
        {
            await UpdateUserToken(id, null);
        }

        public bool IsLoggedIn(int id)
        {
            var user = Users.Find(id);

            return user != null && user.Token != null;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer( // your connection string goes INSIDE THIS METHOD, ALSO CHANGE THE INITIAL CATALOG TO YOUR DATABASE
             @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=OauthApp;Integrated Security=True");
        }
    }
}
