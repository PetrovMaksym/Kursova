using System;

namespace Model.FileCabinet
{
    public class Book
    {
        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public DateTime? BookPublicationDate { get; set; }
        public string BookPublishing { get; set; }
        public decimal BookPrice { get; set; }
        public bool IsExsist { get; set; }
        public DateTime BookDiliveryDate { get; set; }
    }
}
