using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace HW3
{
    static class Converter
    {
        static public void Start()
        {
            string[] lines = File.ReadAllLines("faculties_and_departments.csv");
            XElement xml = new XElement("Elements",
               lines.Select(line => new XElement("Item",
                  line.Split(';').Select((column, index) => new XElement("Column" + index, column)))));
            xml.Save("faculties_and_departments.xml");
        }
    }
}
