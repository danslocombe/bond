using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bond.IO.Safe;
using Bond.Protocols;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest;

namespace Bond.Net6Tests
{
    [TestClass]
    public class BasicTests
    {
        [TestMethod]
        public void TestNullRequired()
        {
            var instance = new DanTest()
            {
                date = null,
                blah = null,
                optional_date = null,
            };

            var s = new Serializer<CompactBinaryWriter<OutputBuffer>>(typeof(DanTest));
            var buffer = new OutputBuffer();
            var writer = new CompactBinaryWriter<OutputBuffer>(buffer);

            s.Serialize(instance, writer);

        }
    }
}
