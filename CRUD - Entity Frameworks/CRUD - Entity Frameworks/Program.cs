using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CRUD___Entity_Frameworks

public class Program
{
    static void Main(string[] args)
    {
        TestDatabase();
    }

    public static void TestDatabase()
    {
        UserRepository repository = new UserRepository();

        Console.WriteLine("Initial user list:");
        PrintUsers(repository.ListAllUsers());

        User newUser = new User { Name = "Gurvinder Singh", Email = "gurvindersingh@gmail.com" };
        repository.AddUser(newUser);
        Console.WriteLine("After adding a new user:");
        PrintUsers(repository.ListAllUsers());

        newUser.Name = "Gurvinder Singh Sidhu";
        repository.UpdateUser(newUser);
        Console.WriteLine("After updating the user:");
        PrintUsers(repository.ListAllUsers());

        repository.DeleteUser(newUser.Id);
        Console.WriteLine("After deleting the user:");
        PrintUsers(repository.ListAllUsers());
    }

    public static void PrintUsers(List<User> users)
    {
        foreach (var user in users)
        {
            Console.WriteLine($"ID: {user.Id}, Name: {user.Name}, Email: {user.Email}");
        }
    }
}
