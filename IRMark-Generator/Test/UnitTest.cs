using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;
using HMRC.IRMark.Generator;
using Xunit;

namespace Test
{
    public class UnitTest
    {
        [Fact]
        public async Task CheckIrMark()
        {
            var sample = await File.ReadAllTextAsync("C:\\Users\\ivant\\source\\repos\\HMRC-IRMark\\IRMark-Generator\\Test\\sampleXml.xml");
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(sample);
            var irMarkGenerator = new IrMarkGenerator(sample);
            var result = await irMarkGenerator.EmbedIrMarkAsync();

            Assert.NotNull(result);
        }
    }
}
