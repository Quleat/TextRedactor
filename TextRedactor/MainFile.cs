using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TextRedactor
{
    class MainFile
    {
        public FontData FontData { get; set; }
        public DateData DateData { get; set; }

        string Text;

        public MainFile()
        {
            FontData = new FontData(DefaultValues.defaultFont);
            DateData = new DateData(DefaultValues.currentTime);
        }
        /// <summary>
        /// Constructor for creating new file
        /// </summary>
        /// <param name="font"></param>
        /// <param name="date"></param>
        public MainFile(Font font, DateTime date)
        {
            FontData = new FontData(font);
            DateData = new DateData(date);
        }

        /// <summary>
        /// Constructor for loading document without declaration
        /// </summary>
        /// <param name="font"></param>
        /// <param name="date"></param>
        /// <param name="text"></param>
        public MainFile(Font font, DateTime date, string text) : this(font, date)
        {
            Text = text;
        }

        /// <summary>
        /// Constructor for loading document with declaration
        /// </summary>
        /// <param name="fontData"></param>
        /// <param name="dateData"></param>
        /// <param name="text"></param>
        public MainFile(FontData fontData, DateData dateData, string text)
        {
            FontData = fontData;
            DateData = dateData;
            Text = text;
        }
        public string ConvertData(bool addDeclaration, string text)
        {
            Text = text;
            return Converter.Convert(Text, addDeclaration, new AbstractData[] {FontData, DateData});
        }
    }
}
