namespace AlbumTime
{
    public static class PhotoBookTest
    {
        public static void TestingTime()
        {
            Console.WriteLine("________________");
            var defaultPhotoBook = new PhotoBookDataModel();
            Console.WriteLine($"This photo book has {defaultPhotoBook.GetNumberPages()} pages.");
            Console.WriteLine("________________");
            var standardPhotoBook = new PhotoBookDataModel(24);
            Console.WriteLine($"This photo book has {standardPhotoBook.GetNumberPages()} pages.");
            Console.WriteLine("________________");
            var bigPhotoBook = new BigPhotoBookDataModel();
            Console.WriteLine($"This photo book has {bigPhotoBook.GetNumberPages()} pages.");
            Console.WriteLine("________________");
            Console.ReadLine();
        }
    }
}
