using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_3_var3
{
    public class FileDrugStorage : Dobavlenie
    {
        List<Films> Dobavlenie.LoadDataFromCsv()
        {
            List<Films> allMovie = new List<Films>();
            string path = "data3.csv";
            StreamReader info = new StreamReader(path);
            string line;
            while ((line = info.ReadLine()) != null)
            {
                string[] lines = line.Split(';');
                allMovie.Add(new Films(lines[1], lines[2], lines[3], lines[4], Convert.ToInt32(lines[5]), Convert.ToInt32(lines[6]), lines[0]));
            }
            info.Close();
            return allMovie;
        }
    }
}
