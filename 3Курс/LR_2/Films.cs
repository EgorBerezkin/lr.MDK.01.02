using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_3_var3
{
    class Films
    {
        private string name_;
        private string opisanie_;
        private string rejiser_;
        private string date_;
        private double summ_;
        private int number_;
        private string foto_;

        public string Name
        {
            get { return name_; }
        }

        public string Opisanie
        {
            get { return opisanie_; }
        }

        public string Rejiser
        {
            get { return rejiser_; }
        }

        public string Date
        {
            get { return date_; }
        }

        public double Summ
        {
            get { return summ_; }
        }

        public int Number
        {
            get { return number_; }
        }

        public string Foto
        {
            get { return foto_; }
        }

        public Films(string name, string opisanie, string rejiser, string date, double summ, int number, string foto)
        {
            name_ = name;
            opisanie_ = opisanie;
            rejiser_ = rejiser;
            date_ = date;
            summ_ = summ;
            number_ = number;
            foto_ = foto;
        }

        
    }
}
