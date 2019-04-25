using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NoteBookOnWeb.Database
{
    public class NoteBookDbContext: DbContext
    {
        public DbSet<Note> Notes { get; set; }
    }
}