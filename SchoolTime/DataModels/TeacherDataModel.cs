namespace SchoolTime
{
    /// <summary>
    /// Represents a teacher
    /// </summary>
    public class TeacherDataModel : PersonDataModel
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TeacherDataModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Prints a message notifying that the current <see cref="StudentDataModel"/> is studying
        /// </summary>
        public void Explain() => Console.WriteLine("I'm explaining.");

        #endregion
    }
}
