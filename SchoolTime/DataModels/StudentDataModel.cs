namespace SchoolTime
{
    /// <summary>
    /// Represents a student
    /// </summary>
    public class StudentDataModel : PersonDataModel
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public StudentDataModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Prints a message notifying that the current <see cref="StudentDataModel"/> is studying
        /// </summary>
        public void Study() => Console.WriteLine("I'm studying.");

        /// <summary>
        /// Prints a message with the current <see cref="StudentDataModel"/>'s age
        /// </summary>
        public void ShowAge() => Console.WriteLine($"My age is: {mAge} years old.");

        #endregion
    }
}
