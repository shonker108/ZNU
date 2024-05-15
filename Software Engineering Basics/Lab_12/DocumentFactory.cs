using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_12
{
    public static class DocumentFactory
    {
        public static IDocumentFormatGenerator GetDocumentFormatGenerator(string format)
        {
            switch (format)
            {
                case "html":
                    return new HTMLDocumentFormatGenerator();
                case "txt":
                    return new TxtDocumentFormatGenerator();
                case "bin":
                    return new BinaryDocumentFormatGenerator();
                default:
                    throw new ArgumentException("Наданий формат нерозпізнано!");
            }
        }
    }

    public class BinaryDocumentFormatGenerator : IDocumentFormatGenerator
    {
        public void SaveDocument(string text, string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                byte[] bytes = Encoding.UTF8.GetBytes(text);
                stream.Write(bytes, 0, bytes.Length);
            }
        }
    }

    public class TxtDocumentFormatGenerator : IDocumentFormatGenerator
    {
        public void SaveDocument(string text, string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write(text);
            }
        }
    }

    public class HTMLDocumentFormatGenerator : IDocumentFormatGenerator
    {
        public void SaveDocument(string text, string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("<!DOCTYPE html>");
                writer.WriteLine("<html lang=\"ru\">");
                writer.WriteLine("<head>");
                writer.WriteLine("<meta charset=\"UTF-8\">");
                writer.WriteLine($"<title>Some title</title>");
                writer.WriteLine("</head>");
                writer.WriteLine("<body>");

                // Розділяємо текст по абзацам за допомогою '\n'
                string[] paragraphs = text.Split(Environment.NewLine);

                foreach (string paragraph in paragraphs)
                {
                    writer.WriteLine($"<p>{paragraph}</p>");
                }

                writer.WriteLine("</body>");
                writer.WriteLine("</html>");
            }
        }
    }

    public interface IDocumentFormatGenerator
    {
        public void SaveDocument(string text, string path);
    }
}
