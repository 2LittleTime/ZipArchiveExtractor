using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace ExtractQclcdFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define array of zip file names
            string[] filesArray = Directory.GetFiles(@"F:\QCLCD_RawData");

            Console.WriteLine("--QCLCD Files--");
            
            //Loop through all the zip archive files
            foreach (string fileName in filesArray)
            {
                Console.WriteLine("File name is: {0}", fileName.ToString());

                //Define the extract point
                string extractPath = @"F:\QCLCD_RawData\extract";

                //Open the zipArchive file
                using (ZipArchive archive = ZipFile.OpenRead(fileName.ToString()))
                {
                    //Loop through the entries in the archive
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        Console.WriteLine("Entry {0}", entry.FullName.ToString());

                        //extract the *daily.txt files and copy to the extract directory
                        if (entry.FullName.EndsWith("daily.txt", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("DailyFile is {0}", entry.FullName.ToString());
                            entry.ExtractToFile(Path.Combine(extractPath, entry.FullName));
                            Console.WriteLine("DailyFile extracted..", entry.FullName.ToString());
                        }

                    }
                    
                } 
                

            }

            Console.WriteLine("Press enter to finish.");
            Console.ReadLine();
        }
    }
}
