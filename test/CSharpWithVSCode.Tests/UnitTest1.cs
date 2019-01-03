using System;
using Xunit;
using CSharpWithVSCode.ClassLib;

namespace CSharpWithVSCode.Tests
    {
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("Hello", new Class1().sayHello());
        }
    }
}
