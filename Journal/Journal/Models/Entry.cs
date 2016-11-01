using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Journal.Models
{
    public class Entry
    {
        public int EntryId { get; set; }

        public string Prompt { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

    }

    public class EntryContext : DbContext
    {
        public DbSet<Entry> Entries { get; set; }
    }
}