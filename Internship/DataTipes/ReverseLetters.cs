using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship.DataTipes
{
    public class ReverseLetters
    {
        public string Result { get; set; }
        public void EnterLeter(char v, char v1, char v2)
        {
            StringBuilder c = new StringBuilder();
            c.Append(v2);
            c.Append(" ");
            c.Append(v1);
            c.Append(" ");
            c.Append(v);

            char[] d = new char[5];
            d[0] = v2;
            d[1] = ' ';
            d[2] = v1;
            d[3] = ' ';
            d[4] = v;



            Result = new string(d);

            //string test = new string();
            //string c = v2.ToString() + " " + v1 + " " + v;
            Result = c.ToString();
        }
        
    }
}
