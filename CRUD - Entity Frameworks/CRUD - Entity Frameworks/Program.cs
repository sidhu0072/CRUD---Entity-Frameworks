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

        // List all users initially
        Console.WriteLine("Initial user list:");
        PrintUsers(repository.ListAllUsers());

        // Add a new user
        User newUser = new User { Name = "John Doe", Email = "john.doe@example.com" };
        repository.AddUser(newUser);
        Console.WriteLine("After adding a new user:");
        PrintUsers(repository.ListAllUsers());

        // Update the user
        newUser.Name = "John A. Doe";
        repository.UpdateUser(newUser);
        Console.WriteLine("After updating the user:");
        PrintUsers(repository.ListAllUsers());

        // Delete the user
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