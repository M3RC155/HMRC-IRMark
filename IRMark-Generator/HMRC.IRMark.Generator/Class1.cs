using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace HMRC.IRMark.Generator
{
    public class Class1
    {
        public string GetAlgorithm()
        {
            string transformStr = @"<?xml version='1.0'?>
<dsig:Transforms xmlns:dsig='http://www.w3.org/2000/09/xmldsig#' xmlns:gt='http://www.govtalk.gov.uk/CM/envelope'>
    <dsig:Transform Algorithm='http://www.w3.org/TR/1999/REC-xpath-19991116'>
        <dsig:XPath>
            (count(ancestor-or-self::node()|/gt:GovTalkMessage/gt:Body)=count(ancestor-or-self::node()))
            and
            (count(ancestor-or-self::node()|/gt:GovTalkMessage/gt:Body/*[name()='IRenvelope']/*[name()='IRheader']/*[name()='IRmark'])!=count(ancestor-or-self::node()))
        </dsig:XPath>
    </dsig:Transform>
    <dsig:Transform Algorithm='http://www.w3.org/TR/2001/REC-xml-c14n-20010315#WithComments'/>
</dsig:Transforms>";
            return transformStr;
        }

        public static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: IRMarkCalculator <file>");
                return;
            }
            FileInfo newFile = new FileInfo(args[0]);
            Console.WriteLine("FILEPATH: " + args[0]);
            FileStream fis = null;
            try
            {
                fis = newFile.OpenRead();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file " + newFile + " could not be opened.");
                return;
            }
            Class1 mc = new Class1();
            Console.WriteLine();
            Console.WriteLine("IRMark for file " + newFile.Name);
            Console.WriteLine();
            Console.WriteLine("       Base64 --> " + mc.CreateMark(fis));
            Console.WriteLine();
            Console.WriteLine("============================================================");
        }

        public const string DEFAULT_SEC_HASH_ALGORITHM = "SHA";

        public string CreateMark(Stream inStream)
        {
            return ToBase64(GetMarkBytes(inStream));
        }

        private byte[] GetMarkBytes(Stream inStream)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(GetAlgorithm());

            // Load XPath transform
            XmlDsigXPathTransform xpathTransform = new XmlDsigXPathTransform();
            var xpathNodes = doc.DocumentElement.SelectNodes("//dsig:XPath");
            xpathTransform.LoadInnerXml(xpathNodes);

            // Load Canonicalization transform
            XmlDsigC14NWithCommentsTransform c14nTransform = new XmlDsigC14NWithCommentsTransform();
            var c14nNodes = doc.DocumentElement.SelectNodes("//dsig:Transform[2]");
            c14nTransform.LoadInnerXml(c14nNodes);

            // Perform the transforms
            MemoryStream ms = new MemoryStream();
            inStream.CopyTo(ms);
            ms.Position = 0;

            // Apply transforms
            XmlDocument transformedDoc = new XmlDocument();
            XPathNavigator nav = doc.CreateNavigator();
            XPathExpression expr = nav.Compile("//dsig:XPath");
            expr.SetContext(new XmlNamespaceManager(nav.NameTable));
            ms.Position = 0;
            byte[] transformedBytes = PerformTransforms(ms, xpathTransform, c14nTransform);

            Console.WriteLine("\noutput = \n" + Encoding.UTF8.GetString(transformedBytes));

            using (SHA1Managed sha = new SHA1Managed())
            {
                sha.TransformBlock(transformedBytes, 0, transformedBytes.Length, null, 0);
                sha.TransformFinalBlock(new byte[0], 0, 0);
                return sha.Hash;
            }
        }

        private byte[] PerformTransforms(MemoryStream ms, params Transform[] transforms)
        {
            byte[] inputBytes = ms.ToArray();
            foreach (Transform transform in transforms)
            {
                //transform.LoadInnerXml(ms);
                ms.Position = 0;
                inputBytes = transform.GetOutput() as byte[];
                ms = new MemoryStream(inputBytes);
            }
            return inputBytes;
        }

        public static string ToBase64(byte[] irMarkBytes)
        {
            return Convert.ToBase64String(irMarkBytes);
        }
    }
}
