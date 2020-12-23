using System;

namespace ConsoleApp1
{
    public class SomeService : ISomeService
    {
        public IDbContextMock DbContext { get; }

        public SomeService(IDbContextMock dbContextMock)
        {
            DbContext = dbContextMock;
            Console.WriteLine("In some service constructor");
        }
    }

    public interface ISomeService
    {
        public IDbContextMock DbContext { get; }
    }
}