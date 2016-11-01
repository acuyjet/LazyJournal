using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Journal.Models
{
    public class Entry
    {
        public int EntryId { get; set; }

        public DateTime Date { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

    }

    public class EntryContext : DbContext
    {
        public DbSet<Entry> Entries { get; set; }

        public EntryContext()
        {
            Database.SetInitializer<EntryContext>(new DatabaseContextInitializer());
        }

        public class DatabaseContextInitializer : DropCreateDatabaseIfModelChanges<EntryContext>
        {
            public override void InitializeDatabase(EntryContext context)
            {
                base.InitializeDatabase(context);
                if (!context.Entries.Any(x => x.EntryId == 1))
                {
                    context.Entries.Add(new Models.Entry()
                    {
                        EntryId = 1,
                        Date = DateTime.Now,
                        Title = "Sample Journal Entry",
                        Text = "Every day is taco ipsum tuesday. These tacos are lit 🔥. It’s taco Tuesday Monday. Fish tacos: lettuce or cabbage, pico de gallo, avocado and a sour cream or citrus/mayonnaise sauce, all placed on top of a corn or flour tortilla. Flour or corn tortillas? CARNE ASADA!! 50 cent tacos! I’ll take 30. If you were a taco, would you eat yourself? Add in a few el Pastor with guac and diced onions. Tacos al pastor made with adobada meat. I’ve been following that taco truck around all day. TACOS!!",
                    });
                    context.SaveChanges();
                }
            }
        }
    }

}