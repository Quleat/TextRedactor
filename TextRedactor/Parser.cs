using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextRedactor
{
    static class Parser
    {
        public static string Parse(string text, params AbstractData[] datas)
        {
            if (!text.StartsWith("<"))
            {
                foreach(AbstractData data in datas)
                {
                    data.Restore();
                }
                return ParseWithoutDeclaration(text);
            }
            
            int lastIndex = text.IndexOf('>');
            string declaration = text.Substring(1, lastIndex - 1);

            Dictionary<string, string> pairs = new Dictionary<string, string>();

            string[] splited = declaration.Split(new char[] { ';' });
            foreach(string sourcePair in splited)
            {
                if (sourcePair == "")
                    continue;

                string[] pair = sourcePair.Split(new char[] { ':' });
                pairs.Add(pair[0], pair[1]);
            }

            foreach(AbstractData data in datas)
            {
                try
                {
                    data.Restore(pairs[data.Name]);
                }
                catch (Exception ex)
                {
                    data.Restore();
                }
            }

            return ParseWithoutDeclaration(text.Substring(lastIndex + 2));
        }
        private static string ParseWithoutDeclaration(string text)
        {
            return text;
        }
    }
}
