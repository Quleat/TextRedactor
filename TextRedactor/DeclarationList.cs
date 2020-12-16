using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;

namespace TextRedactor
{
    public class DeclarationList : IEnumerable<KeyValuePair<string, string>>
    {
        //Font
        public string familyName {
            get
            {
                return variables["familyName"];
            }
            set
            {
                variables["familyName"] = value;
            }
        }
        public float emSize { 
            get
            {
                return float.Parse(variables["emSize"]);
            }
            set
            {
                variables["emSize"] = value.ToString();
            }
        }
        public FontStyle style
        {
            get
            {
                return (FontStyle)Enum.Parse(typeof(FontStyle), variables["style"]);
            }
            set
            {
                variables["style"] = value.ToString();
            }
        }
        public GraphicsUnit unit
        {
            get
            {
                return (GraphicsUnit)Enum.Parse(typeof(GraphicsUnit), variables["unit"]);
            }
            set
            {
                variables["unit"] = value.ToString();
            }
        }
        public byte gdiCharSet
        {
            get
            {
                return Byte.Parse(variables["gdiCharSet"]);
            }
            set
            {
                variables["gdiCharSet"] = value.ToString();
            }
        }
        public bool gdiVerticalFont
        {
            get
            {
                return Boolean.Parse(variables["gdiVerticalFont"]);
            }
            set
            {
                variables["gdiVerticalFont"] = value.ToString();
            }
        }

        public bool disposed = false;

        Dictionary<string, string> variables = new Dictionary<string, string>();
        public DeclarationList()
        {
            variables = new Dictionary<string, string>();
        }
        public DeclarationList(Dictionary<string, string> dic)
        {
            variables = dic;
        }

        static public DeclarationList Parse(string text)
        {
            Dictionary<string, string> objects = new Dictionary<string, string>();
            string[] allData = text.Split(new char[] { ';', ':' });
            int current = 0;
            while(current < allData.Length)
            {
                objects.Add(allData[current++], allData[current++]);
            }
            return new DeclarationList(objects);
        }
        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            return variables.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)variables).GetEnumerator();
        }
    }
}
