using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Milo.Tests
{
    public class MyTests
    {
        [Fact]
        public void MyTest()
        {
            Assert.Equal(4, 2 + 2);
        }
    }
}
