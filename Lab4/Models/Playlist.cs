using System;
using System.ComponentModel.DataAnnotations;

namespace Lab4.Models
{
    public class Playlist
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DataType(DataType.DateTime)] // need time & date
        public DateTime addDate { get; set; }
        public string Author { get; set; }
        public string Kind { get; set; }
    }
}
