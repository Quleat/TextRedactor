using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TextRedactor
{
    public static class FontExtension
    {
        /// <summary>
        /// The string should has special format
        /// </summary>
        /// <param name="font"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static Font TryParse(this Font font, string text)
        {
            try
            {
                string[] splitedUp = text.Split(new char[] { '/' });

                string familyName = splitedUp[0];
                float emSize = Single.Parse(splitedUp[1]);
                FontStyle style = (FontStyle)Enum.Parse(typeof(FontStyle), splitedUp[2]);
                GraphicsUnit unit = (GraphicsUnit)Enum.Parse(typeof(GraphicsUnit), splitedUp[3]);
                byte gdiCharset = Byte.Parse(splitedUp[4]);
                bool gdiVerticalFont = Boolean.Parse(splitedUp[5]);

                return new Font(familyName, emSize, style, unit, gdiCharset, gdiVerticalFont);
            }
            catch
            {
                return DefaultValues.defaultFont;
            }
        }
    }
}
