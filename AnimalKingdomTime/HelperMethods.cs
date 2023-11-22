namespace AnimalKingdomTime
{
    public static class HelperMethods
    {
        #region Public Methods

        public static string GetTextFromConsole(string requestMessage)
        {
            Console.WriteLine(requestMessage);
            
            var text = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Invalid input!");

                return GetTextFromConsole(requestMessage);
            }

            return text;
        }

        #endregion
    }
}
