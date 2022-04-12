using FormTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormTask.FakeRepo
{
    public class UserRepo
    {
        public static List<User> Users { get; set; } = new List<User>
        {
                new User
                {
                    Id=1,
                    Name="Elton",
                    Surname="Johnlu",
                    ImagePath="image1.png",
                    Age=55
                },
                new User
                {
                    Id=2,
                    Name="John ",
                    Surname="Johnlu",
                    ImagePath="image2.jpeg",
                    Age=88
                }
             
        };
    }
}
