using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace TextRedactor
{
    public class FileFacade
    {
        TextReader reader { get; set; }
        TextWriter writer { get; set; }

        public SourceFile file;

        public FileFacade()
        {
            reader = new DeclarationReader();
            writer = new DefaultWriter();
            file = new SourceFile();
        }

        public FileFacade(TextReader _reader, TextWriter _writer)
        {
            reader = _reader;
            writer = _writer;
            file = new SourceFile();
        }

        public string Load(string path)
        {
            file.path = path;
            file.text = reader.Read(ref file);
            return file.text;
        }

        public void Save(string path, string text)
        {
            file.text = text;
            writer.Write(path, file);
        }

        public void ChangeFont(Font newFont)
        {
            file.UpdateFont(newFont);
        }
    }

    public class DefaultReader : TextReader
    {
        [Obsolete]
        public override string Read(string path)
        {
            return File.ReadAllText(path);
        }
        public override string Read(ref SourceFile file)
        {
            file.text = File.ReadAllText(file.path);
            return file.text;
        }
    }

    public class DeclarationReader : DefaultReader
    {
        public override string Read(ref SourceFile file)
        {
            base.Read(ref file);
            //Precheck.
            if (!file.text.StartsWith("<"))
                return file.text;

            //Finding declaration text and parsing it into DeclarationList.
            int length = file.text.IndexOf(">");
            string declaration = file.text.Substring(1, length - 2);
            file.declarationList = DeclarationList.Parse(declaration);

            //Returning text without declaration.
            return file.text.Substring(length + 1);
        }
    }

    public class DefaultWriter : TextWriter
    {
        public override void Write(string path, string text)
        {
            File.WriteAllText(path, text);
        }
        public override void Write(string path, SourceFile file)
        {
            Write(path, file.text);
        }
    }

    public class DeclarationWriter : DefaultWriter
    {
        public override void Write(string path, SourceFile file)
        {
            StringBuilder builder = new StringBuilder("<");
            foreach (KeyValuePair<string, string> pair in file.declarationList)
            {
                builder.Append(String.Format("{0}:{1}", pair.Key, pair.Value));
            }
            builder.Append(">");
            Write(path, builder.ToString() + file.text);
        }
    }

    public abstract class TextWriter
    {
        public abstract void Write(string path, string content);
        public abstract void Write(string path, SourceFile file);
    }

    public abstract class TextReader
    {
        [Obsolete]
        public abstract string Read(string path);

        public abstract string Read(ref SourceFile file);
    }
}
