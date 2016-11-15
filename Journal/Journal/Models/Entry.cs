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
                if (!context.Entries.Any(x => x.EntryId < 4))
                {
                    context.Entries.Add(new Models.Entry()
                    {
                        EntryId = 1,
                        Date = DateTime.Parse("1/1/2016"),
                        Title = "Deep Thoughts About Tacos",
                        Text = "Every day is taco ipsum tuesday. These tacos are lit 🔥. It’s taco Tuesday Monday. Fish tacos: lettuce or cabbage, pico de gallo, avocado and a sour cream or citrus/mayonnaise sauce, all placed on top of a corn or flour tortilla. Flour or corn tortillas? CARNE ASADA!! 50 cent tacos! I’ll take 30. If you were a taco, would you eat yourself? Add in a few el Pastor with guac and diced onions. Tacos al pastor made with adobada meat. I’ve been following that taco truck around all day. TACOS!!"
                    });
                    context.Entries.Add(new Models.Entry()
                    {
                        EntryId = 2,
                        Date = DateTime.Parse("1/2/2016"),
                        Title = "Deep Thoughts About Cats",
                        Text = "Sniff other cat's butt and hang jaw half open thereafter chew on cable. See owner, run in terror. Who's the baby swat at dog. Lick the other cats destroy couch russian blue for sit in box Gate keepers of hell sit in window and stare ooo, a bird! yum poop on grasses. Lick arm hair catch mouse and gave it as a present, refuse to leave cardboard box but cats go for world domination, scratch at the door then walk away. Stares at human while pushing stuff off a table bleghbleghvomit my furball really tie the room together or purr while eating and walk on car leaving trail of paw prints on hood and windshield yet friends are not food."
                    });
                    context.Entries.Add(new Models.Entry()
                    {
                        EntryId = 3,
                        Date = DateTime.Parse("1/3/2016"),
                        Title = "Deep Thoughts About Zombies",
                        Text = "Zombie ipsum reversus ab viral inferno, nam rick grimes malum cerebro. De carne lumbering animata corpora quaeritis. Summus brains sit​​, morbo vel maleficia? De apocalypsi gorger omero undead survivor dictum mauris.Hi mindless mortuis soulless creaturas, imo evil stalking monstra adventus resi dentevil vultus comedat cerebella viventium.Qui animated corpse, cricket bat max brucks terribilem incessu zomby. The voodoo sacerdos flesh eater, suscitat mortuos comedere carnem virus.Zonbi tattered for solum oculi eorum defunctis go lum cerebro. Nescio brains an Undead zombies. Sicut malus putrid voodoo horror.Nigh tofth eliv ingdead."
                    });
                context.SaveChanges();
                }
            }
        }
    }

}