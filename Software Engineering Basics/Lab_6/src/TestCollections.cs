using Lab_6.MyClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6.src
{
    public class TestCollections
    {
        private readonly List<Team> listTeams;
        private readonly List<string> listStrings;
        private readonly Dictionary<Team, ResearchTeam> dictTeamResearchTeam;
        private readonly Dictionary<string, ResearchTeam> dictStringResearchTeam;

        public TestCollections(int count)
        {
            listTeams = new List<Team>(count);
            listStrings = new List<string>(count);
            dictTeamResearchTeam = new Dictionary<Team, ResearchTeam>(count);
            dictStringResearchTeam = new Dictionary<string, ResearchTeam>(count);

            for (int i = 1; i <= count; i++)
            {
                var value = GenerateElement(i);
                listTeams.Add(value);
                listStrings.Add(value.ToString());
                dictTeamResearchTeam.Add((Team)value, value);
                dictStringResearchTeam.Add(value.ToString(), value);
            }
        }

        public static ResearchTeam GenerateElement(int id)
        {
            ResearchTeam team = new ResearchTeam();
            team.RegistrationNumber = id;
            return team;
        }

        public void FindElementTime()
        {
            var teamKey = listTeams[0];
            var startTime = Stopwatch.StartNew();
            listTeams.Contains(teamKey);
            var timeListTeam = startTime.ElapsedMilliseconds;

            var stringKey = listStrings[0];
            startTime = Stopwatch.StartNew();
            listStrings.Contains(stringKey);
            var timeListString = startTime.ElapsedMilliseconds;

            startTime = Stopwatch.StartNew();
            dictTeamResearchTeam.ContainsKey(teamKey);
            var timeDictTeamResearchTeamKey = startTime.ElapsedMilliseconds;

            startTime = Stopwatch.StartNew();
            dictTeamResearchTeam.ContainsValue(GenerateElement(1));
            var timeDictTeamResearchTeamValue = startTime.ElapsedMilliseconds;

            Console.WriteLine("List<Team>: {0} мс", timeListTeam);
            Console.WriteLine("List<string>: {0} мс", timeListString);
            Console.WriteLine("Dictionary<Team, ResearchTeam> (ключ): {0} мс", timeDictTeamResearchTeamKey);
            Console.WriteLine("Dictionary<Team, ResearchTeam> (значення): {0} мс", timeDictTeamResearchTeamValue);
        }
    }
}
