// See https://aka.ms/new-console-template for more information
// Name: James
// Date: June 18, 2025
// Lab: Lab 4 - Mastermind

{
        // Greeting
        Console.WriteLine("Welcome to Mastermind!");
        Console.WriteLine("Guess the 4-letter secret code made of letters a-g (no repeats).");
        Console.WriteLine("You'll be told how many letters are correct and in the right place,");
        Console.WriteLine("and how many letters are correct but in the wrong place.");
        Console.WriteLine();
        string secret = "afdb"; // Hard-coded secret
        int guessCount = 0;
        string guess;

        do
        {
            // Ask for guess
            Console.Write("Enter your 4-letter guess (a-g, no repeats): ");
            guess = Console.ReadLine()!.ToLower();
            guessCount++;

            // Input validation
            if (guess.Length != 4)
            {
                Console.WriteLine("Your guess must be exactly 4 letters.");
                continue;
            }

            if (!AllLettersValid(guess))
            {
                Console.WriteLine("Only use letters from 'a' to 'g'.");
                continue;
            }

            if (HasDuplicates(guess))
            {
                Console.WriteLine("No repeated letters allowed.");
                continue;
            }
        // Count correct positions
            int correctPosition = 0;
            for (int i = 0; i < 4; i++)
            {
                if (guess[i] == secret[i])
                {
                    correctPosition++;
                }
            }

            // Count correct letters in wrong positions
            int correctLetterWrongPlace = 0;
            for (int i = 0; i < 4; i++)
            {
                if (guess[i] != secret[i])
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (i != j && guess[i] == secret[j])
                        {
                            correctLetterWrongPlace++;
                            break;
                        }
                    }
                }
            }
        // Feedback to user
            if (guess != secret)
            {
                Console.WriteLine($"Guess #{guessCount}: {guess}");
                Console.WriteLine($"{correctPosition} letter(s) in correct position.");
                Console.WriteLine($"{correctLetterWrongPlace} correct letter(s) in wrong position.\n");
            }

        } while (guess != secret);

        // Win message
        Console.WriteLine($"\nCongratulations! You guessed the secret '{secret}' in {guessCount} guesses.");
    }

    // Check if all letters are between 'a' and 'g'
    static bool AllLettersValid(string guess)
    {
        foreach (char c in guess)
        {
            if (c < 'a' || c > 'g')
                return false;
        }
        return true;
    }

    // Check for duplicate letters
    static bool HasDuplicates(string guess)
    {
        for (int i = 0; i < guess.Length; i++)
        {
            for (int j = i + 1; j < guess.Length; j++)
            {
                if (guess[i] == guess[j])
                    return true;
            }
        }
    return false;
    }
            
            






    
        
        