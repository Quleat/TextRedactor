using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace TextRedactor
{
    class FileHandler
    { 
        MainFile mainFile;

        Reader reader;
        Writer writer;

        public Font Font
        {
            get
            {
                return mainFile.FontData.Font; //&&&&&&&&
            }
            set
            {
                mainFile.FontData.Font = value;
            }
        }

        public DateTime date
        {
            get
            {
                return mainFile.DateData.Date;
            }
            set
            {
                mainFile.DateData.Date = value;
            }
        }

        private bool saveDeclaration;
        public bool SaveDeclaration
        {
            get
            {
                return saveDeclaration;
            }
            set
            {
                saveDeclaration = value;
                if (!saveDeclaration)
                {
                    SaveFont = false;
                    SaveDate = false;
                }
            }
        }
        public bool SaveFont
        {
            get
            {
                return mainFile.FontData.Enabled;
            }
            set
            {
                mainFile.FontData.Enabled = value;
            }
        }
        public bool SaveDate
        {
            get
            {
                return mainFile.DateData.Enabled;
            }
            set
            {
                mainFile.DateData.Enabled = value;
            }
        }

        public FileHandler(MainFile file)
        {
            mainFile = file;

            writer = new DefaultWriter();
            reader = new DefaultReader();
        }
        public string Load(string path)
        {
            string text = reader.Load(path);
            return Parser.Parse(text, mainFile.FontData, mainFile.DateData);
        }

        public void Save(string path, string text)
        {
            writer.Save(path, mainFile.ConvertData(SaveDeclaration, text));
        }
    }
}
