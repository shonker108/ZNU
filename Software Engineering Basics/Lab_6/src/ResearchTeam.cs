using Lab_6.src;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab_6.MyClasses
{
    public enum TimeFrame
    {
        Year,
        TwoYears,
        Long
    }

    public class ResearchTeam : Team, INameAndCopy, IComparer<ResearchTeam>
    {
        private string topic;
        private TimeFrame timeFrame;
        private List<Person> members;
        private List<Paper> papers;

        public ResearchTeam(string name, string topic, int registrationNumber, TimeFrame timeFrame)
        {
            this.name = name;
            this.topic = topic;
            this.registrationNumber = registrationNumber;
            this.timeFrame = timeFrame;
            this.papers = new List<Paper>();
            this.members = new List<Person>();
        }

        public ResearchTeam()
        {
            name = string.Empty;
            topic = "No topic";
            registrationNumber = 0;
            timeFrame = new TimeFrame();
            papers = new List<Paper>();
            members = new List<Person>();
        }

        public string Topic
        {
            get =>  topic;
            set =>  topic = value;
        }

        public TimeFrame TimeFrame
        {
            get =>  timeFrame;
            set =>  timeFrame = value;
        }

        public List<Paper> Papers
        {
            get =>  papers;
            set =>  papers = value;
        }

        public List<Person> Members
        {
            get => members;
            set => members = value;
        }

        public Team Team
        {
            get => new Team(name, registrationNumber);
            set
            {
                name = value.Name;
                registrationNumber = value.RegistrationNumber;
            }
        }

        public Paper LatestPaper
        {
            get
            {
                if (papers.Count == 0)
                    return null;

                Paper latest = (Paper)papers[0];

                for (int i = 1; i < papers.Count; i++)
                {
                    Paper paper = (Paper)papers[i];
                    if (paper.PublicationDate > latest.PublicationDate)
                        latest = paper;
                }

                return latest;
            }
        }

        public bool this[TimeFrame timeFrame]
        {
            get =>  this.timeFrame.Equals(timeFrame);
        }

        public void AddPapers(params Paper[] papers)
        {
            foreach (Paper paper in papers)
            {
                this.papers.Add(paper);
            }
        }

        public void AddMembers(params Person[] members)
        {
            foreach (Person member in members)
            {
                this.members.Add(member);
            }
        }

        public override string ToString()
        {
            string papersList = "";
            foreach (Paper paper in papers)
            {
                papersList += paper.ToString() + "\n";
            }

            string membersList = "";
            foreach (Person member in members)
            {
                membersList += member.ToString() + "\n";
            }

            return 
                $"Name: {name}\n" +
                $"Topic: {topic}\n" +
                $"Registration number: {registrationNumber}\n" +
                $"Duration of the research: {timeFrame}\n" +
                $"Publication list:\n" + papersList +
                $"Members list:\n" + membersList;
        }

        public virtual string ToShortString()
        {
            return
               $"Name: {name}\n" +
               $"Topic: {topic}\n" +
               $"Registration number: {registrationNumber}\n" +
               $"Duration of the research: {timeFrame}\n";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            ResearchTeam other = (ResearchTeam)obj;

            if (papers.Count != other.papers.Count)
                return false;

            for (int i = 0; i < papers.Count; i++)
            {
                if (!((Paper)papers[i]).Equals((Paper)other.papers[i]))
                    return false;
            }

            if (members.Count != other.members.Count) return false;

            for (int i = 0; i < members.Count; i++ )
            {
                if (!((Person)members[i]).Equals((Person)other.members[i]))
                    return false;
            }

            return topic == other.topic &&
                   name == other.name &&
                   registrationNumber == other.registrationNumber &&
                   timeFrame.Equals(other.timeFrame);
        }

        public static bool operator ==(ResearchTeam rt1, ResearchTeam rt2)
        {
            if (rt1 is null || rt2 is null)
            {
                return false;
            }

            return rt1.Equals(rt2);
        }

        public static bool operator !=(ResearchTeam rt1, ResearchTeam rt2)
        {
            return !(rt1 == rt2);
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + topic.GetHashCode();
            hash = hash * 23 + name.GetHashCode();
            hash = hash * 23 + registrationNumber.GetHashCode();
            hash = hash * 23 + timeFrame.GetHashCode();
            return hash;
        }

        
        // Не дуже зрозумів задачу з "T"-об'єктами. Нащо нам T-об'єкт, який
        // і так є нашим класом. Тому я видалив старий метод DeepCopy і визначив тип
        // повернення, як цей клас.
        public override ResearchTeam DeepCopy()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ResearchTeam));
                serializer.Serialize(stream, this);
                
                // Переходимо на початок потоку
                stream.Position = 0;
                
                return (ResearchTeam)serializer.Deserialize(stream)!;
            }
        }

        public bool Save(string filename)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (Paper paper in papers)
                    {
                        writer.WriteLine(paper.Title);
                        writer.WriteLine(paper.Author.Name);
                        writer.WriteLine(paper.Author.Surname);
                        writer.WriteLine(paper.Author.BirthYear);
                        writer.WriteLine(paper.PublicationDate);
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool Load(string filename)
        {
            List<Paper> loadedPapers = new List<Paper>();

            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    while (!reader.EndOfStream)
                    {
                        string title = reader.ReadLine()!;
                        string authorName = reader.ReadLine()!;
                        string authorSurname = reader.ReadLine()!;
                        DateTime authorBirthDate = DateTime.Parse(reader.ReadLine()!);
                        DateTime publicationDate = DateTime.Parse(reader.ReadLine()!);

                        Person author = new Person(authorName, authorSurname, authorBirthDate);
                        Paper paper = new Paper(title, author, publicationDate);

                        loadedPapers.Add(paper);
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }

            papers.Clear();
            papers.AddRange(loadedPapers);

            return true;
        }

        public static bool Save(string filename, ResearchTeam researchTeam)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (Paper paper in researchTeam.papers)
                    {
                        writer.WriteLine(paper.Title);
                        writer.WriteLine(paper.Author.Name);
                        writer.WriteLine(paper.Author.Surname);
                        writer.WriteLine(paper.Author.BirthYear);
                        writer.WriteLine(paper.PublicationDate);
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public static bool Load(string filename, ResearchTeam researchTeam)
        {
            List<Paper> loadedPapers = new List<Paper>();

            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    while (!reader.EndOfStream)
                    {
                        string title = reader.ReadLine()!;
                        string authorName = reader.ReadLine()!;
                        string authorSurname = reader.ReadLine()!;
                        DateTime authorBirthDate = DateTime.Parse(reader.ReadLine()!);
                        DateTime publicationDate = DateTime.Parse(reader.ReadLine()!);

                        Person author = new Person(authorName, authorSurname, authorBirthDate);
                        Paper paper = new Paper(title, author, publicationDate);

                        loadedPapers.Add(paper);
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }

            researchTeam.papers.Clear();
            researchTeam.papers.AddRange(loadedPapers);

            return true;
        }

        public bool AddFromConsole()
        {
            string input, title, authorName, authorSurname;
            DateTime birthDate, publicationDate;
            const string SEPARATOR = ";"; // роздільник

            Console.WriteLine("Введіть дані про публікацію у форматі:");
            Console.WriteLine("[Назва публікації]{0}[Ім'я автора]{0}[Прізвище автора]{0}[Дата народження автора]{0}[Дата публікації]", SEPARATOR);
            Console.WriteLine("Приклад: \"Біологія;Іван;Іванович;10-12-2001;11-04-2024\"");

            try
            {
                input = Console.ReadLine();
                string[] parts = input.Split(SEPARATOR);

                if (parts.Length != 5)
                    throw new FormatException("Неправильний формат даних!");

                title = parts[0];
                authorName = parts[1];
                authorSurname = parts[2];

                DateOnly birthDate_do = DateOnly.Parse(parts[3]);
                birthDate = new DateTime(birthDate_do.Year, birthDate_do.Month, birthDate_do.Day);
                
                DateOnly publicationDate_do = DateOnly.Parse(parts[4]);
                publicationDate = new DateTime(publicationDate_do.Year, publicationDate_do.Month, publicationDate_do.Day);

                Person author = new Person(authorName, authorSurname, birthDate);
                Paper paper = new Paper(title, author, publicationDate);

                papers.Add(paper);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
                return false;
            }

            return true;
        }

        public IEnumerable<Person> GetParticipantsWithoutPublications()
        {
            foreach (Person member in members)
            {
                if (member.publicationsCount == 0)
                {
                    yield return member;
                }
            }
        }

        public IEnumerable<Paper> GetPublicationsByYear(int yearsAgo)
        {
            // Так як в Л/Р не сказано як саме визначати останні n років, то
            // я рахую їх від сьогодні (зараз), віднімаючи надані роки
            DateTime nYearsAgo = DateTime.Now.AddYears(-yearsAgo);
            foreach (Paper paper in papers)
            {
                if (paper.PublicationDate >= nYearsAgo)
                {
                    yield return paper;
                }
            }
        }

        public int Compare(ResearchTeam? x, ResearchTeam? y)
        {
            return x.topic.CompareTo(y.topic);
        }
    }
}
