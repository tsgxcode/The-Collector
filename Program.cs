using System;

namespace The_Collector
{
    class Program
    {
        /* The collector. A catolog of music.
         As the user buidls or reduces their record colletion, 
         the user can save, edit, and remove items and save this info to 
         a document.
        */

        static void Main(string[] args)
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
            Console.Write("Album title: ");
            string AlbumTitle = Console.ReadLine();
        }


    }
}
  