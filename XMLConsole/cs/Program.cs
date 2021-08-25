using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Shift_JIS"を読み込む方法※WindowsFormsなら不要
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            //xmlファイルを指定する※ファイルパスは@が必要
            XElement xml = XElement.Load(@"C:\Users\h-kashiwagi\Desktop\XMLConsole\XMLConsole\XML\sample.xml");

            //メンバー情報のタグ内の情報を取得する
            IEnumerable<XElement> infos = from item in xml.Elements("メンバー情報")select item;

            //メンバー情報分ループして、コンソールに表示
            foreach (XElement info in infos)
            {
                Console.Write(info.Element("名前").Value + @",");
                Console.Write(info.Element("住所").Value + @",");
                Console.WriteLine(info.Element("年齢").Value);
            }

            Console.ReadKey();

        }
    }
}
