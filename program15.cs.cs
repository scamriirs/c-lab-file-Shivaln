15. Implement the concept of file handling to read xml file and display all the values in a read only form. 
OUTPUT: 

using System;
using System.Xml.Linq;
using System.IO;

class XMLReader
{
   static void Main()
   {
       string filePath = "data.xml";
       
       if (File.Exists(filePath))
       {
           XDocument doc = XDocument.Load(filePath);
           Console.WriteLine("XML File Content:");
           Console.WriteLine(doc);
       }
       else
       {
           Console.WriteLine("Error: XML file not found!");
           
       }
       }
   }