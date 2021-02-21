using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lab5
{
    public class FileOperations
    {
        String file = "modules.txt";
        List<String> modules = new List<String>();
        public FileOperations()
        {
            // Check if file exisits if not create the file
            if (File.Exists(file))
            {
                File.Delete(file);
            }

            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.WriteLine("Initialize");
                sw.WriteLine("Sum");
                sw.WriteLine("Subtract");
                sw.WriteLine("Product");
                sw.WriteLine("Power");
                sw.WriteLine("Log");
            }


            using (StreamReader reader = new StreamReader(file))
            {
           
                String line = null;
           
                while ((line = reader.ReadLine()) != null)
                {
                    modules.Add(line);
                }
            }
        }

        public List<String> getModules()
        {           
            return modules;
        }

    }
}
