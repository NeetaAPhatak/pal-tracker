using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace PalTracker
{
    public class TimeEntryContext : DbContext
    {
        public TimeEntryContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TimeEntryRecord> TimeEntryRecords { get; set; }
    }
}
