﻿namespace WebApplication2.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public int? PublishedYear { get; set; }

        public Author Author { get; set; }
        public Genre Genre { get; set; }
    }
}
