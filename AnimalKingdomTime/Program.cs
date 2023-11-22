using AnimalKingdomTime;

var name = HelperMethods.GetTextFromConsole("Please give a name to your pet.");

var pet = new DogDataModel();

pet.SetName(name);

pet.Eat();

Console.ReadLine();
