using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TextRedactor
{
    public static class DefaultValues
    {
        readonly public static Font defaultFont = new Font("Microsoft Sans Serif", 8f);
        public static DateTime currentTime 
        {   get
            {
                return DateTime.Now;
            }
        }
    }
}
