namespace Common.Utils.NumberGenerators;

public static class NumberGenerators
{
    public static string GenerateCardNumber(string prefix)
    {
        Random random = new Random();

        string cardNumber = prefix;
        while (cardNumber.Length < 15)
        {
            cardNumber += random.Next(0, 10);
        }

        int checkDigit = CalculateLuhnCheckDigit(cardNumber);
        cardNumber += checkDigit;

        return cardNumber;
    }

    public static int CalculateLuhnCheckDigit(string cardNumberWithoutCheckDigit)
    {
        int sum = 0;
        bool alternate = true;
        for (int i = cardNumberWithoutCheckDigit.Length - 1; i >= 0; i--)
        {
            int digit = int.Parse(cardNumberWithoutCheckDigit[i].ToString());

            if (alternate)
            {
                digit *= 2;
                if (digit > 9)
                {
                    digit -= 9;
                }
            }

            sum += digit;
            alternate = !alternate;
        }

        return (10 - (sum % 10)) % 10;
    }

    public static string GenerateExpiryDate()
    {
        Random random = new Random();
        return random.Next(1, 13).ToString("D2") + random.Next(1, 31).ToString("D2");
    }

    public static string GenerateSecurityCode()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 1000);
        return randomNumber.ToString("D3");
    }
}
