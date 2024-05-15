using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6.src
{
    public class TeamsJournal
    {
        private List<TeamsJournalEntry> entries;

        public TeamsJournal()
        {
            entries = new List<TeamsJournalEntry>();
        }

        public void OnResearchTeamChange(object source, TeamListHandlerEventArgs args)
        {
            entries.Add(new TeamsJournalEntry(args.Name, args.ChangeType, args.Index));
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var entry in entries)
            {
                sb.AppendLine(entry.ToString());
            }
            return sb.ToString();
        }
    }

    public class TeamsJournalEntry
    {
        public string Name { get; set; }
        public string ChangeType { get; set; }
        public int Index { get; set; }

        public TeamsJournalEntry(string name, string changeType, int index)
        {
            Name = name;
            ChangeType = changeType;
            Index = index;
        }

        public override string ToString()
        {
            return $"Name: {Name}, ChangeType: {ChangeType}, Index: {Index}";
        }
    }
}
