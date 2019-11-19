using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    
    class DiadaSemana
    {
        private DateTime data;

        public string recebe
        {
            set
            {
                data = Convert.ToDateTime(value);
            }
        }

        public string envia
        {
            get
            {
                return "O dia da semana em que voce nasceu é" + data.ToString("dddd") +".";
            }
        }
       

    }
}
