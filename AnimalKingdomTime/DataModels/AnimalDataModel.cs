namespace AnimalKingdomTime
{
    /// <summary>
    /// Represents an animal
    /// </summary>
    public abstract class AnimalDataModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Name"/> property
        /// </summary>
        private string? mName;

        #endregion

        #region Public Properties

        /// <summary>
        /// The name
        /// </summary>
        public string Name 
        { 
            get => mName ?? string.Empty;
            set => mName = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AnimalDataModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Sets the <see cref="Name"/> of the current <see cref="AnimalDataModel"/>
        /// </summary>
        /// <param name="name">The name</param>
        public void SetName(string name) => Name = name;

        /// <summary>
        /// Gets the current <see cref="AnimalDataModel"/>'s name
        /// </summary>
        public string GetName() => Name;

        /// <summary>
        /// Notifies the user that the current <see cref="AnimalDataModel"/> is eating
        /// </summary>
        public abstract void Eat();

        #endregion
    }
}
