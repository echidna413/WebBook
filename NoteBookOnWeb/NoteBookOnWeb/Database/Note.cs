using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NoteBookOnWeb
{
    public class Note
    {

        [Key]
        public int note_id { get; set; }
        public DateTime date_ { get; set; }
        public string topic { get; set; }
        public string  text_note { get; set; }
    }
}