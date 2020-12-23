using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Globalization;

namespace TextRedactor
{
    /// <summary>
    /// Returns converted data in string
    /// </summary>
    public class DateData : AbstractData
    {
        public DateTime Date;
        public DateData(DateTime dateTime) : base("date")
        {
            Date = dateTime;
        }
        public override string[] getValues()
        {
            return new string[] {String.Format("{2}/{1}/{0} {3}-{4}-{5}",Date.Year.ToString(), Date.Month.ToString(),
                Date.Day.ToString(), Date.Hour.ToString(), Date.Minute.ToString(),
                Date.Second.ToString())};
        }
        public override void Restore(string text)
        {
            Date = DateTime.ParseExact(text, "dd/MM/yyyy HH-mm-ss/", CultureInfo.InvariantCulture);
        }
        public override void Restore()
        {
            Date = DefaultValues.currentTime;
        }
    }
    /// <summary>
    /// Returns converted font in string
    /// </summary>
    public class FontData : AbstractData
    {
        public Font Font;
        public FontData(Font _font) : base("font")
        {
            Font = _font;
        }
        public override string[] getValues()
        {
            return new string[] {Font.FontFamily.Name, Font.Size.ToString(), Font.Style.ToString(),
                Font.Unit.ToString(), Font.GdiCharSet.ToString(), Font.GdiVerticalFont.ToString()};
        }
        public override void Restore(string text)
        {
            Font = Font.TryParse(text);
        }
        public override void Restore() 
        {
            Font = DefaultValues.defaultFont;
        }
    }
    public abstract class AbstractData
    {
        public bool Enabled;
        public string Name;
        public AbstractData(string name)
        {
            Name = name;
        }
        public abstract string[] getValues();
        public abstract void Restore(string text);
        public abstract void Restore();
    }
    
}
