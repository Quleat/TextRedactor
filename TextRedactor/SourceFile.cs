using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TextRedactor
{
    public class SourceFile
    {
        public string path { get; set; } //Add precheck
        public string text { get; set; }
        public Font font;
        public DeclarationList declarationList { get; set; }

        public SourceFile()
        {
            declarationList = new DeclarationList();
        }

        //Updating font field from declarationList data
        public Font UpdateFont()
        {
            //Updating font from declarationListData
            font = new Font(declarationList.familyName, declarationList.emSize,
                    declarationList.style, declarationList.unit, declarationList.gdiCharSet,
                    declarationList.gdiVerticalFont);
            return font;
        }

        //Setting new font in field and declarationList.
        public Font UpdateFont(Font newFont)
        {
            font = newFont;

            //Updating declarationList's font information.
            declarationList.familyName = newFont.FontFamily.Name;
            declarationList.emSize = newFont.Size;
            declarationList.style = newFont.Style;
            declarationList.unit = newFont.Unit;
            declarationList.gdiCharSet = newFont.GdiCharSet;
            declarationList.gdiVerticalFont = newFont.GdiVerticalFont;

            return font;
        }
    }
}
