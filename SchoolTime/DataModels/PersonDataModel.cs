namespace SchoolTime
{
    /// <summary>
    /// Represents a person
    /// </summary>
    public class PersonDataModel
    {
        #region Protected Members

        /// <summary>
        /// The age
        /// </summary>
        protected uint mAge;

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PersonDataModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Prints a greeting message 
        /// </summary>
        public void Greet() => Console.WriteLine("Hello world!");

        /// <summary>
        /// Sets the age for the current <see cref="PersonDataModel"/>
        /// </summary>
        public void SetAge(uint age) => mAge = age;

        #endregion
    }
}
