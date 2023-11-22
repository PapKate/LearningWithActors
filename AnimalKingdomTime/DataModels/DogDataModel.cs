namespace AnimalKingdomTime
{
    /// <summary>
    /// Represents a dog
    /// </summary>
    public class DogDataModel : AnimalDataModel
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DogDataModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine($"{GetName()} is currently eating!");
        }

        #endregion
    }
}
