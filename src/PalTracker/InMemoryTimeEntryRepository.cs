using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PalTracker
{
    public class InMemoryTimeEntryRepository :  ITimeEntryRepository
    {
        private readonly IDictionary<long, TimeEntry> _timeEntries = new Dictionary<long, TimeEntry>();

        public TimeEntry Create(TimeEntry timeEntry)
        {
            var id = _timeEntries.Count + 1;

            timeEntry.Id = id;

            _timeEntries.Add(id, timeEntry);

            return timeEntry;
        }

        public TimeEntry Find(long id) => _timeEntries[id];

        public bool Contains(long id) => _timeEntries.ContainsKey(id);

        public IEnumerable<TimeEntry> List() => _timeEntries.Values.ToList();

        public TimeEntry Update(long id, TimeEntry timeEntry)
        {
            timeEntry.Id = id;

            _timeEntries[id] = timeEntry;

            return timeEntry;
        }

        public void Delete(long id)
        {
            _timeEntries.Remove(id);
        }
        /*
        private List<TimeEntry> TimeEntryList;

        public TimeEntry Create(TimeEntry timeEntry)
        {
            TimeEntry tm = null;

            if ((timeEntry.Id) == null)
            {
                tm = new TimeEntry(timeEntry.ProjectId, timeEntry.UserId, timeEntry.Date, timeEntry.Hours);
            }
            else
            {
                tm = new TimeEntry(Convert.ToInt16(timeEntry.Id), timeEntry.ProjectId, timeEntry.UserId, timeEntry.Date, timeEntry.Hours);
            }

            TimeEntryList.Add(tm);
            return tm;
        }

        public TimeEntry Find(long id)
        {
            TimeEntry tm = TimeEntryList.Find(x => x.Id == id);
            return tm;
        }

        public bool Contains(long id)
        {
            TimeEntry tm = TimeEntryList.Find(x => x.Id == id);
            return tm!=null;
        }

        public IEnumerable<TimeEntry> List()
        {
            return TimeEntryList;
        }

        public TimeEntry Update(long id, TimeEntry timeEntry)
        {
            int entryIndex = TimeEntryList.FindIndex(x => x.Id == id);
            if (entryIndex >= 0)
            {
                TimeEntryList[entryIndex] = timeEntry;
                return timeEntry;
            }
            else return null;
        }

        public void Delete(long id)
        {
            int entryIndex = TimeEntryList.FindIndex(x => x.Id == id);
            if (entryIndex >= 0)
                TimeEntryList.RemoveAt(entryIndex);
        }*/
    }
}
