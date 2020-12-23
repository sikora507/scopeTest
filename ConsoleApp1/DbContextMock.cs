using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class DbContextMock : IDbContextMock
    {
        public DbContextMock()
        {
            Console.WriteLine("In db context constructor");
        }
    }

    public interface IDbContextMock
    {
    }
}
