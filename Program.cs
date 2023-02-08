
#region Main program

string input;

do
{
    System.Console.Write("Please enter a number: ");
    input = Console.ReadLine()!;
    if (input == "q")
    {
        return;
    }

    System.Console.WriteLine(NumberIntoLongTextLevel1(int.Parse(input)));

    System.Console.WriteLine(NumberIntoLongTextLevel3(int.Parse(input)));

} while (true);

#endregion

string DigitIntoLongText(int number)
{
    return number

    switch
    {
        0 => "zero",
        1 => "one",
        2 => "two",
        3 => "three",
        4 => "four",
        5 => "five",
        6 => "six",
        7 => "seven",
        8 => "eight",
        9 => "nine",
        _ => "not a digit",
    };
}

string NumberIntoLongTextLevel1(int number)
{
    if (number < 10) { return DigitIntoLongText(number); }
    if (number > 99) { return "not a number"; }

    if (number < 20)
    {
        return number

        switch
        {
            10 => "ten",
            11 => "eleven",
            12 => "twelve",
            13 => "thirteen",
            15 => "fifteen",
            18 => "eighteen",
            _ => $"{DigitIntoLongText(number % 10)}teen",
        };
    }

    int leftDigit = number / 10;
    int rightDigit = number % 10;
    string result;


    result = leftDigit switch
    {
        2 => "twenty",
        3 => "thirty",
        4 => "forty",
        5 => "fifty",
        8 => "eighty",
        _ => $"{DigitIntoLongText(leftDigit)}ty",
    };

    if (rightDigit != 0) { result += DigitIntoLongText(rightDigit); }

    return result;
}

string NumberIntoLongTextLevel2(int number)
{
    if (number < 20) { return NumberIntoLongTextLevel1(number); }

    string result = (number / 10) switch
    {
        2 => "twenty",
        3 => "thirty",
        4 => "forty",
        5 => "fifty",
        8 => "eighty",
        _ => $"{DigitIntoLongText(number / 10)}ty"
    };

    if (number % 10 != 0) { result += DigitIntoLongText(number % 10); }

    return result;
}

string NumberIntoLongTextLevel3(int number)
{
    if (number < 100) { return NumberIntoLongTextLevel1(number); }
    if (number > 999) { return "not a valid number"; }

    string result = $"{DigitIntoLongText(number / 100)}hundred";

    if (number % 100 != 0) { result += NumberIntoLongTextLevel2(number % 100); }

    return result;
}