using System.Collections.Generic;

namespace Model.FileCabinet
{
    public class LibraryFileCabinet
    {
        public LibraryFileCabinet()
        {
            Books = new List<Book>();
        }

        public List<Book> Books { get; set; }
    }
}
