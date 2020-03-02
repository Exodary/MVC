using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoAlbum
{
    class PhotoAlbum
    {
        protected int numberOfPages;

        public PhotoAlbum()
        {
            numberOfPages = 16;
        }

        public PhotoAlbum(int numberOfPages)
        {
            this.numberOfPages = numberOfPages;
        }

        public void GetNumberOfPages()
        {
            Console.WriteLine(numberOfPages);
        }
    }
}
