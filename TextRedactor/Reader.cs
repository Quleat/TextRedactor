using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextRedactor
{
    abstract class Reader
    {
        public abstract string Load(string path);
    }
    class DefaultReader : Reader
    {
        public override string Load(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
