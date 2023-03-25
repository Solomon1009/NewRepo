namespace Demo2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Author { get; set; }

        [StringLength(500)]
        public string Des { get; set; }

        public decimal? Price { get; set; }

        [StringLength(250)]
        public string Image { get; set; }

        [ForeignKey("Category")]
        public int CateId { get; set; }

        public int? AuthorId { get; set; }

        public virtual Author Author1 { get; set; }

        public virtual Category Category { get; set; }
    }
}
