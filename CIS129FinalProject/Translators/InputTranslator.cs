using System.Threading.Channels;

namespace CIS129FinalProject;

public static class InputTranslator
{
    // Get Input
    public static GameInput GetInput()
    {
        var input = Console.ReadLine();
        bool isValidInput = IsValidInput(input);

        while (isValidInput is false) 
        {
            Console.WriteLine("Invalid response, please enter a valid number from the previous prompt.");
            input = Console.ReadLine();
            isValidInput = IsValidInput(input);
        }

        return ProduceTranslatedInput(input);
    }

    // Validate Input
    private static bool IsValidInput(string input)
    {
        if (input.Length > 1)
        {
            Console.WriteLine("Please enter a single digit.");
            return false;
        }
        var inputCharacter = Convert.ToChar(input);

        switch (inputCharacter)
        {
            case '1':
                return true;
            case '2':
                return true;
            case '3':
                return true;
            case '4':
                return true;
            case '9':
                return true;
        }

        return false;
    }
    
    // Translate Input
    private static GameInput ProduceTranslatedInput(string input)
    {
        var inputCharacter = Convert.ToChar(input);
        GameInput gameInput = GameInput.None;

        switch (inputCharacter)
        {
            case '1':
                gameInput = GameInput.TheFirstOption;
                break;
            case '2':
                gameInput = GameInput.TheSecondOption;
                break;
            case '3':
                gameInput = GameInput.TheThirdOption;
                break;
            case '4':
                gameInput = GameInput.TheFourthOption;
                break;
            case '9':
                gameInput = GameInput.TheExitOption;
                break;
        }

        return gameInput;
    }
    
}