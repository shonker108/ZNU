using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_6.MyClasses
{
    public class Paper
    {
        public string Title { get; set; }
        public Person Author { get; set; }
        public DateTime PublicationDate { get; set; }

        public Paper(string title, Person author, DateTime publicationDate)
        {
            Title = title;
            Author = author;
            author.publicationsCount++;

            PublicationDate = publicationDate;
        }

        public Paper()
        {
            Title = "No title";
            Author = new Person();
            PublicationDate = new DateTime(2000, 1, 1);
        }

        public override string ToString()
        {
            return $"Title: {Title}\nAuthor: {Author.ToShortString()}\nDate of publication: {PublicationDate.ToString("dd.MM.yyyy")}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Paper other = (Paper)obj;

            return Title == other.Title &&
                   Author == other.Author &&
                   PublicationDate.Equals(other.PublicationDate);
        }

        public static bool operator ==(Paper paper1, Paper paper2)
        {
            if (paper1 is null || paper2 is null)
            {
                return false;
            }

            return paper1.Equals(paper2);
        }

        public static bool operator !=(Paper paper1, Paper paper2)
        {
            return !(paper1 == paper2);
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + Title.GetHashCode();
            hash = hash * 23 + Author.GetHashCode();
            hash = hash * 23 + PublicationDate.GetHashCode();
            return hash;
        }

        public object DeepCopy()
        {
            return new Paper(
                Title,
                (Person)Author.DeepCopy(),
                new DateTime(PublicationDate.Year, PublicationDate.Month, PublicationDate.Day)
            );
        }
    }
}
