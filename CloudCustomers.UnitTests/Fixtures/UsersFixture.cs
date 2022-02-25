using CloudCustomers.API.Models;
using System.Collections.Generic;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() => new()
        {
            new User
            {
                Name = "Test User 1",
                Email = "test1@tdd.com",
                Address = new Address()
                {
                    Street = "123 Main St",
                    City = "SomeCity",
                    ZipCode = "1702"
                }
            },
            new User
            {
                Name = "Test User 2",
                Email = "test2@tdd.com",
                Address = new Address()
                {
                    Street = "108 Maple St",
                    City = "SomeCity",
                    ZipCode = "1702"
                }
            },
            new User
            {
                Name = "Test User 1",
                Email = "test2@tdd.com",
                Address = new Address()
                {
                    Street = "8 Hague St",
                    City = "SomeCity",
                    ZipCode = "1702"
                }
            }
        };
    }
}
