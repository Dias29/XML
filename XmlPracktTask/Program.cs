using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlPracktTask
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument document = new XmlDocument();
            document.Load("Animals.xml");

            XmlElement root = document.DocumentElement;
            XmlNodeList subchild = root.ChildNodes;

            if (root.ChildNodes.HasAttribute(""))
            {
                string kind = root.GetAttribute("kind");
                Console.WriteLine(kind);
            }

            //foreach (XmlElement element in root)
            //{
            //    Animals animal = new Animals();

                

            //    Console.WriteLine(animal.Kind = element.GetAttribute("kind"));
            //    Console.WriteLine(animal.Breed = element.ChildNodes[1].InnerText);
            //    Console.WriteLine(animal.Weight = int.Parse(element.ChildNodes[2].Attributes["weight"].InnerText));
            //    Console.WriteLine(animal.Price = int.Parse(element.ChildNodes[3].Attributes["price"].InnerText));

            //}

            Console.ReadLine();
        }
    }
}


//using System;
//using System.IO;
//using System.Xml;

//public class Sample
//{
//    public static void Main()
//    {

//        XmlDocument doc = new XmlDocument();
//        doc.LoadXml("<book genre='novel' ISBN='1-861001-57-5'>" +
//                    "<title>Pride And Prejudice</title>" +
//                    "</book>");

//        XmlElement root = doc.DocumentElement;

//        // Check to see if the element has a genre attribute.
//        if (root.HasAttribute("genre"))
//        {
//            String genre = root.GetAttribute("genre");
//            Console.WriteLine(genre);
//        }

//        Console.ReadLine();
//    }
//}

