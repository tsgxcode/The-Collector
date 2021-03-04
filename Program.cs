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
        
        /*do
        {
             
               Console.WriteLine("The Collector");
               

               LogArtist();
               Console.WriteLine("Add another Artist? Yes or No");
               if(Console.ReadLine().ToUpper() == "YES");
               {
                 OutPutLog();
               }
               Console.WriteLine("Add another Artist? Yes or No");
             }
             while (Console.ReadLine().ToUpper() == "YES");
          }
          } */

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

      

    }
}