using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using The_Collector;
using System.Text.Json.Serialization;

namespace The_Collector
{
    class Program
    {
        
        /* The collector. A catolog of music.
         As the user buidls or reduces their record colletion, 
         the user can save, edit, and remove items and save this info to 
         a document.
        */

        static void Main()
        
      
        {
            //The Colletor
            Console.Write("Artist name: ");
            string ArtistName = Console.ReadLine();
            Console.Write("Artist Location: ");
            string ArtistLocation = Console.ReadLine();
            Console.WriteLine("Years Active: ");
            string YearsAcitve = Console.ReadLine();
            Console.Write("Number of releases: ");
            string Releases = Console.ReadLine();

            
            File.AppendAllText(
              @"\Users\TSG\source\repos\The Collector\Data.txt",
                $"{(ArtistName + "." + ArtistLocation + "." + YearsAcitve + "." + Releases + ".")}{Environment.NewLine}");
        }

        public static void Artist(){
          /* serialzing data: Read from a file and output results to file,in this case a basic text file*/ 
          string currentDirectory = Directory.GetCurrentDirectory();
          DirectoryInfo directory= new DirectoryInfo(currentDirectory);
          var fileName = Path.Combine(directory.FullName, "Data.txt");
          var fileContents = ReadFile(fileName);
          string[] fileLines = fileContents.Split(new char[] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries);

          foreach (var line in fileLines)
          {
            Console.WriteLine(line);

          }
        }

        public static string ReadFile(string fileName){

          using (var reader = new StreamReader(fileName)){
             return reader.ReadToEnd();
          }
        }

    }
}