using System;

namespace PhotoAlbum
{
    class Program
    {
        static void Main(string[] args)
        {

            PhotoAlbum firstPhotoAlbum = new PhotoAlbum();

            PhotoAlbum secondPhotoAlbum = new PhotoAlbum(24);

            BigPhotoAlbum firstBigPhotoAlbum = new BigPhotoAlbum();

            firstPhotoAlbum.GetNumberOfPages();
            secondPhotoAlbum.GetNumberOfPages();
            firstBigPhotoAlbum.GetNumberOfPages();

        }
    }
}
