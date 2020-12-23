using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextRedactor
{
    abstract class Writer
    {
        public abstract void Save(string path, string text);
    }
    class DefaultWriter : Writer
    {
        public override void Save(string path, string text)
        {
            File.WriteAllText(path, text);
        }
    }
}
