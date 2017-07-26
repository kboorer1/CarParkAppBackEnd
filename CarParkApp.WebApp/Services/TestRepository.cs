using CarParkApp.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarParkApp.WebApp.Services
{
    public class TestRepository
    {
        public Test[] GetAllTests()
        {
            return new Test[]
            {
                new Test
                {
                    Id = 1,
                    Name = "Gleen Block"
                },
                new Test
                {
                    Id = 2,
                    Name = "Dan Roth"
                }
            };
        }
    }
}