using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRedactor
{
    static class Converter
    {
        public static string Convert(string text, bool addDeclaration, params AbstractData[] datas)
        {
            StringBuilder builder = new StringBuilder();

            if (addDeclaration)
            {
                builder.Append("<");
                foreach (AbstractData data in datas)
                {
                    if (!data.Enabled)
                        continue;                                                   // 2 if - пятно на репутации самурая
                    builder.Append(String.Format("{0}:", data.Name));
                    foreach(string variable in data.getValues())
                    {
                        builder.Append(String.Format("{0}/", variable));
                    }
                    builder.Append(";");
                }
                builder.Append(">\n");
            }

            builder.AppendLine(text);

            return builder.ToString();
        }
    }
}
