//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Genre
    {
        public Genre()
        {
            this.Artists = new HashSet<Artist>();
            this.Fans = new HashSet<Fan>();
        }
    
        public int GenreKey { get; set; }
        public string GenreName { get; set; }
        public string GenreDescription { get; set; }
    
        public virtual ICollection<Artist> Artists { get; set; }
        public virtual ICollection<Fan> Fans { get; set; }
    }
}
