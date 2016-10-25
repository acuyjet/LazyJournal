using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Journal.Models
{
    public class Entry
    {

        public Entry()
        {
           
        }

        public int Id { get; set; }

        public string Prompt { get; set; }

        public string Text { get; set; }

    }
}