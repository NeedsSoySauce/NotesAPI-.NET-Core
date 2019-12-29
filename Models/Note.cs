using System;
using System.Collections.Generic;

namespace NotesAPI.Models
{
    public partial class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
