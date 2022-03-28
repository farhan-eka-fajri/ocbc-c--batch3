using System;
namespace MovieApi.Models{

    public class ItemData{

        public int id { get; set; }
        public string name { get; set; }
        public string genre { get; set; }
        public string duration { get; set; }
        public DateTime releaseDate { get; set; }
    }
}