using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanPaymentAutomation
{
    public class FileReader
    {
        private string[] information;

        //Collects Information from a File
        public void ReadFile(string filePath)
        {
            StreamReader file = null;

                //Open the text file
                file = new System.IO.StreamReader(filePath);
                information = new string[13];
                int i = 0;

                while ((information[i] = file.ReadLine()) != null)
                {
                    i++;
                }

                file.Close();
        }

        //Return specified information
        public string info(int i)
        {
            return information[i];
        }
    }
}
