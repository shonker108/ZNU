using Lab_6.MyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_6.src
{
    public delegate void TeamListHandler(object source, TeamListHandlerEventArgs args);
    public class ResearchTeamCollection
    {
        public string Name { get; set; }
        private List<ResearchTeam> researchTeams;

        public event TeamListHandler ResearchTeamAdded;
        public event TeamListHandler ResearchTeamInserted;
        public event TeamListHandler ResearchTeamChanged;

        public ResearchTeamCollection(string name)
        {
            Name = name;
            researchTeams = new List<ResearchTeam>();
        }

        public void AddDefaults()
        {
            researchTeams.Add(new ResearchTeam("Team 3", "Topic of team 2", 1, TimeFrame.TwoYears));
            researchTeams.Add(new ResearchTeam("Team 2", "Topic of team 1", 3, TimeFrame.Year));
            researchTeams.Add(new ResearchTeam("Team 1", "Topic of team 3", 2, TimeFrame.Long));

            researchTeams[0].AddPapers(new Paper(), new Paper());
            researchTeams[1].AddPapers(new Paper());
            researchTeams[2].AddPapers(new Paper(), new Paper(), new Paper());

            researchTeams[0].AddMembers(new Person(), new Person());
            researchTeams[1].AddMembers(new Person(), new Person());
            researchTeams[2].AddMembers(new Person());

            ResearchTeamAdded?.Invoke(this, new TeamListHandlerEventArgs(Name, "ResearchTeamAdded", researchTeams.Count - 1));
        }

        public void AddResearchTeams(params ResearchTeam[] teams)
        {
            foreach (ResearchTeam team in teams)
            {
                researchTeams.Add(team);
                ResearchTeamAdded?.Invoke(this, new TeamListHandlerEventArgs(Name, "ResearchTeamAdded", researchTeams.Count - 1));
            }
        }

        public override string ToString()
        {
            return string.Join("\n", researchTeams.Select(t => t.ToString()));
        }

        public string ToShortString()
        {
            return string.Join("\n", researchTeams.Select(t => t.ToShortString()));
        }

        public void SortByRegistrationNumber()
        {
            researchTeams.Sort((x, y) => x.CompareTo(y));
        }

        public void SortByResearchTopic()
        {
            researchTeams.Sort(new ResearchTeam());
        }

        public void SortByPublicationCount()
        {
            researchTeams.Sort(new ComparingHelper());
        }

        public int MinRegistrationNumber
        {
            get => researchTeams.Any() ? researchTeams.Min(t => t.RegistrationNumber) : default;
        }

        public IEnumerable<ResearchTeam> TwoYearsResearchTeams
        {
            get => researchTeams.Where(t => t.TimeFrame == TimeFrame.TwoYears);
        }
        public List<ResearchTeam> NGroup(int value)
        {
            return researchTeams.GroupBy(t => t.Members.Count)
                .Where(g => g.Key == value)
                .Select(g => g.ToList())
                .FirstOrDefault()!;
        }

        public void InsertAt(int j, ResearchTeam rt)
        {
            if (j < 0 || j > researchTeams.Count)
            {
                Console.WriteLine("Wrong index! Can't insert a team!");
                return;
            }

            if (j == researchTeams.Count)
            {
                researchTeams.Add(rt);
                ResearchTeamAdded?.Invoke(this, new TeamListHandlerEventArgs(Name, "ResearchTeamAdded", j));
            }
            else
            {
                researchTeams.Insert(j, rt);
                ResearchTeamInserted?.Invoke(this, new TeamListHandlerEventArgs(Name, "ResearchTeamInserted", j));
            }

        }

        public ResearchTeam this[int index]
        {
            get => researchTeams[index];
            set {
                researchTeams[index] = value;
                ResearchTeamChanged?.Invoke(this, new TeamListHandlerEventArgs(Name, "ResearchTeamChanged", index));
            }
        }
    }
}
