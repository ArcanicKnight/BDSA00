using System;
using Xunit;

namespace BDSA00.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Main_Prints_Hello_World()
        {
            var writer = new TextWriter();

            Console.SetOut();
        }
    }
}
