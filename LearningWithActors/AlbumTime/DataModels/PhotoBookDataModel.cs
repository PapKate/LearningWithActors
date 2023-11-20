namespace AlbumTime
{
    /// <summary>
    /// Represents a photo-book
    /// </summary>
    public class PhotoBookDataModel
    {
        #region Private Members

        /// <summary>
        /// The total number of pages
        /// </summary>
        private readonly int mNumPages;

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PhotoBookDataModel() : base()
        {
            mNumPages = 16;    
        }

        /// <summary>
        /// Standard constructor
        /// </summary>
        /// <param name="numberOfPages">The total number of pages</param>
        public PhotoBookDataModel(int numberOfPages) : base()
        {
            if (numberOfPages <= 0)
                throw new ArgumentException($"The number of pages provided is invalid! A photo book cannot be created with {numberOfPages} pages.", nameof(numberOfPages));
            mNumPages = numberOfPages;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the current <see cref="PhotoBookDataModel"/>'s number of pages
        /// </summary>
        /// <returns></returns>
        public int GetNumberPages()
        {
            return mNumPages;
        }

        #endregion
    }
}
