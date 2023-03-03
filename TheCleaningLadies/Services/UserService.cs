using RazorPagesUser.Models;

namespace RazorPagesUser.Services;

public static class UserService
{
    static List<User> Users { get; }
    static int nextId = 2;
    static UserService() 
    {
        Users = new List<User>
        {
            new User{ Id = 1, firstName = "Ian", lastName = "Gallo" } 
        };
    }
    
    public static List<User> GetAll() => Users;

    public static User? Get(int id) => Users.FirstOrDefault(u => u.Id == id);

    public static void Add(User user)
    {
        user.Id = nextId++;
        Users.Add(user);
    }

    public static void Delete(int id)
    {
        var user = Get(id);
        if (user is null) {
            return;
        }

        Users.Remove(user);
    }

    public static void Update(User user)
    {
        var index = Users.FindIndex(p => p.Id == user.Id);
        if (index == -1) {
            return;
        }

        Users[index] = user;
    }

}