// .1

//Console.Write("Fyll i ditt namn: ");
//string name = Console.ReadLine();
//Console.WriteLine($"Hej {name}!");


// .2

//string currentPass = "Hej1234";
//bool passLoop = false;
//Console.Write("\nFyll i ditt lösenord: ");
//while (passLoop == false)
//{
//    string userPass = Console.ReadLine();
//    if (currentPass == userPass)
//    {
//        Console.WriteLine("Välkommen!");
//        passLoop = true;
//    }
//    else
//    {
//        Console.Write("\nFel lösenord. Vänligen försök igen: ");
//    }
//}


// .3

//string userNumber = "";
//do
//{
//    Console.Write("Skriv ett tal mellan 0-200: ");
//    userNumber = Console.ReadLine();
//    if (!string.IsNullOrEmpty(userNumber))
//    {
//        int number;
//        int.TryParse(userNumber, out number);
//        if (number == 100)
//        {
//            Console.WriteLine("\nDitt tal är lika med 100.");
//        }
//        else if (number > 100)
//        {
//            Console.WriteLine("\nDitt tal är större än 100.");
//        }
//        else if (number < 100)
//        {
//            Console.WriteLine("\nDitt tal är mindre än 100.");
//        }
//        else
//        {
//            Console.WriteLine("\nParse failed.");
//        }
//    }
//    else
//    {
//        Console.WriteLine("\nEmpty input, please try again");
//    }
//} while (string.IsNullOrEmpty(userNumber));


// .4

//Console.Write("Fyll i ditt namn: ");
//string name2 = Console.ReadLine();
//Console.Write("Fyll i ett tal mellan 1-5: ");
//string tal = Console.ReadLine();
//int talAsInt = int.Parse(tal);

//for (int i = 0; i < talAsInt; i++)
//{
//    Console.WriteLine($"\nHej {name2}!");
//}


// .5

//bool isTrue = true;
//double userInputs = 0;
//double sum = 0;
//double medel = 0.0;

//while (isTrue)
//{
//    Console.Write("Skriv ett tal: ");
//    string userNumber = Console.ReadLine();
//    int.TryParse(userNumber, out int numberAsInt);
//    if (!string.IsNullOrEmpty(userNumber))
//    {
//        sum += numberAsInt;
//        userInputs++;
//        Console.WriteLine(sum);
//        Console.WriteLine($"Antal inmatningar: {userInputs}");
//    }
//    else
//    {
//        isTrue = false;
//    }
//}

//medel = sum / userInputs;
//Console.WriteLine($"Medelvärdet av talen är: {medel}");


// .6

//Console.Write("Skriv ett första tal: ");
//string firstInput = Console.ReadLine();
//double firstNum = double.Parse(firstInput);

//Console.WriteLine("\nVälj räknesätt med tangenterna 1-4 \n(1) +\n(2) -\n(3) *\n(4) /");
//string userCalcMethod = Console.ReadLine();
//int.TryParse(userCalcMethod, out int userCalcMethodInteger);

//Console.Write("\nSkriv ett andra tal: ");
//string secondInput = Console.ReadLine();
//double secondNum = double.Parse(secondInput);

//double result = 0;
//string calcMethod = "";
//switch (userCalcMethodInteger)
//{
//    case 1:
//        result = firstNum + secondNum;
//        calcMethod = "+";
//        break;
//    case 2:
//        result = firstNum - secondNum;
//        calcMethod = "-";
//        break;
//    case 3:
//        result = firstNum * secondNum;
//        calcMethod = "*";
//        break;
//    case 4:
//        result = firstNum / secondNum;
//        calcMethod = "/";
//        break;
//}

//Console.WriteLine($"{firstNum} {calcMethod} {secondNum} = {result}");


// .7
//Skriv ett program som ber användaren skriva in en månad.
//Programmet ska göra om månaden till månadens siffervärde.
//T.ex. ska januari bli 1 och december 12. Använd switch.
//Alternativ: Prova även att lösa uppgiften med array och/eller enum.

//Console.Write("Skriv in en månad: ");
//string month = Console.ReadLine();

//switch (month.ToLower()) // ToLower, tvingar till gemener
//{
//    case "januari":
//        Console.WriteLine("\nDu valde månad: 1");
//        break;
//    case "februari":
//        Console.WriteLine("\nDu valde månad: 2");
//        break;
//    case "mars":
//        Console.WriteLine("\nDu valde månad: 3");
//        break;
//    case "april":
//        Console.WriteLine("\nDu valde månad: 4");
//        break;
//    case "maj":
//        Console.WriteLine("\nDu valde månad: 5");
//        break;
//    case "juni":
//        Console.WriteLine("\nDu valde månad: 6");
//        break;
//    case "juli":
//        Console.WriteLine("\nDu valde månad: 7");
//        break;
//    case "augusti":
//        Console.WriteLine("\nDu valde månad: 8");
//        break;
//    case "september":
//        Console.WriteLine("\nDu valde månad: 9");
//        break;
//    case "oktober":
//        Console.WriteLine("\nDu valde månad: 10");
//        break;
//    case "november":
//        Console.WriteLine("\nDu valde månad: 11");
//        break;
//    case "december":
//        Console.WriteLine("\nDu valde månad: 12");
//        break;
//}

// .7 Array

//Console.Write("Skriv in en månad: ");
//string userMonth = Console.ReadLine();
//string[] months = { "januari", "februari", "mars", "april", "maj", "juni", "juli", "augusti", "september", "oktober", "november", "december" };

//string searchString = userMonth.ToLower();
//int index = Array.IndexOf(months, searchString);
//Console.WriteLine(index + 1);


// .7 Lösning med enum

//Console.Write("Skriv in en månad: ");
////enums index är samma som en array 0 till antal värden, uppifrån och ner.
//string userInput = Console.ReadLine();
//Month myIndex;
//Enum.TryParse(userInput.ToLower(), out myIndex);
//Console.WriteLine((int)myIndex); // Hardcastar till int vilket kan leda till problem
//public enum Month
//{
//    januari = 1, // = 1 anger "index-värdet" 1 istället för 0
//    februari = 2,
//    mars = 3,
//    april = 4,
//    maj = 5,
//    juni = 6,
//    juli = 7,
//    augusti = 8,
//    september = 9,
//    oktober = 10,
//    november = 11,
//    december = 12
//}


// .7 Extra utmaning
//Extra utmaning: Be användaren om två månader och räkna sedan ut hur många månader som skiljer
//mellan dem. Tänk på att ett månaderna upprepas till nästa år.
//Skriver man mars och maj bör man få 2. Likaså om man skriver november och januari.


// .8
// Skapa ett program som skriver ut 1 på första raden, 2 på nästa, sedan 4, o.s.v
// (dubbelt så hög siffra för varje rad). Fortsätt till du skrivit ut 16 rader.

//int outNumber = 1;

//for (int i = 0; i < 16; i++)
//{
//    Console.WriteLine(outNumber);
//    outNumber = outNumber * 2;
//}


// .9
//Random random = new Random();
//int secretNumber = random.Next(0, 101);
//int userInput;
//int numTrys = 1;

//while (true)
//{
//    Console.WriteLine("Gissa det hemliga talet mellan 1-100:");
//    string userNumber = Console.ReadLine();
//    int.TryParse(userNumber, out userInput);

//    if (userInput > secretNumber)
//    {
//        Console.WriteLine("Det hemliga talet är mindre än angivet tal.");
//        numTrys++;
//    }
//    else if (userInput < secretNumber)
//    {
//        Console.WriteLine("Det hemliga talet är större än angivet tal.");
//        numTrys++;
//    }
//    else
//    {
//        Console.WriteLine($"Du gissade rätt!\nDet tog dig {numTrys} försök att gissa rätt.");
//        break;
//    }
//}


// .10
// Be användaren mata in en sträng.
// Skriv ut varje tecken i strängen på en egen rad. Ex: Hej => H e j

//Console.Write("Skriv valfritt ord eller text:");
//string userText = Console.ReadLine();
//foreach (char c in userText)
//{
//    Console.WriteLine(c);
//}


// .11
// Skapa ett program med en array som innehåller strängarna
// “noll”, “ett”, “två”, “tre”, “fyra”, “fem”, “sex”, “sju”, “åtta”, “nio”.
// Be sedan användaren att mata in en siffra. Använd arrayen för att skriva ut siffrans ord.
// Ex. Inmatning “3” => “tre”.

//Extra utmaning: Användaren kan mata in en sträng med fritt antal siffror,
//om man skriver in t.ex 432 så svarar programmet: “fyra - tre - två”.

//string[] numbers = new string[] 
//{ "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };

//Console.Write("Skriv en siffra: ");
//string userNumber = Console.ReadLine();
//int.TryParse(userNumber, out int userInput);

//Console.WriteLine(numbers[userInput]);


// .12
// Fråga användaren hur många tal den vill mata in.
// Fråga sedan efter talen i tur och ordning (“Ange tal 1:” osv).
// När alla tal är inmatade skriv ut dem i omvänd ordning.

//Console.Write("Hur många tal vill du mata in: ");
//string numberOfInputs = Console.ReadLine();
//int.TryParse(numberOfInputs, out int index);

//int[] inputString = new int[index];

//Console.WriteLine("");

//for (int i = 0; i < inputString.Length; i++)
//{
//    Console.Write($"Ange tal {i+1}: ");
//    inputString[i] = int.Parse(Console.ReadLine());
//}

//Console.WriteLine("");

//Array.Reverse(inputString);

//for (int i = 0; i < inputString.Length; i++)
//{
//    Console.WriteLine($"{inputString[i]}");
//}


// .13
// Be användaren mata in en text. Skriv sedan ut texten baklänges.

//string Reverse(string userText)
//{
//    char[] charArray = userText.ToCharArray();
//    Array.Reverse(charArray);
//    return new string(charArray);
//}

//Console.Write("Mata in en text: ");
//string userText = Console.ReadLine();
//userText = Reverse(userText);

//Console.WriteLine(userText);


// .14
// Be användaren mata in en text. Skriv ut texten med alla vokaler ersatta med *
// Extra utmaning: Skriv ut texten översatt till rövarspråket. EJ GJORD

//Console.Write("Skriv en text: ");
//string userText = Console.ReadLine();

//char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };

//if (userText.Length > 0)
//{
//    for (int i = 0; i < userText.Length; i++)
//    {
//        if (userText.Contains(vowels[i]))
//        {
//            Console.WriteLine(userText.Replace(vowels[i], '*'));
//        }
//    }
//}
//else
//{
//    Console.WriteLine("Det fanns inga vokaler i ditt ord");
//}

//Console.WriteLine("stop");


// .15
// Ett palindrom är ett ord som blir samma framlänges som baklänges.
// Be användaren skriva in ett ord och ange sedan om det är ett palindrom eller inte.

//string Reverse(string userText)
//{
//    char[] charArray = userText.ToCharArray();
//    Array.Reverse(charArray);
//    return new string(charArray);
//}

//Console.Write("Skriv en palindrom: ");
//string userText = Console.ReadLine();
//string reversedText = Reverse(userText);

//if (userText == reversedText)
//{
//    Console.WriteLine($"Din text: {userText}\nBaklänges: {reversedText}");
//}
//else
//{
//    Console.WriteLine("Din text är ingen palindrom.");
//}


// .16
// Gör om uppgift 6 så man kan mata in allt på en rad
// (första talet, operator, andra talet). Ignorera inmatade mellanslag i strängen.
// Om man t.ex. matar in strängen “34 - 14”, så ska programmet skriva ut “= 20”.

//Console.Write("Vad ska jag räkna ut (separera med mellanslag): ");
//string userInput = Console.ReadLine(); 
//string[] userInputParts = userInput.Split(' ');

//string firstInput = userInputParts[0];
//string userCalcMethod = userInputParts[1];
//string secondInput = userInputParts[2];

//double firstNum = double.Parse(firstInput);
//double secondNum = double.Parse(secondInput);

//string userCalcMethodInteger = userInputParts[1];

//double result = 0;
//string calcMethod = "";
//switch (userCalcMethodInteger)
//{
//    case "+":
//        result = firstNum + secondNum;
//        break;
//    case "-":
//        result = firstNum - secondNum;
//        break;
//    case "*":
//        result = firstNum * secondNum;
//        break;
//    case "/":
//        result = firstNum / secondNum;
//        break;
//}

//Console.WriteLine($"= {result}");


// .17

//Ex. Användare matar in “abcdefghijklmnopqrstuvxyz”, och sedan “defg”.
//Programmet ska då skriva ut: abcdefghijklmnopqrstuvxyz

//använd substring

//Gör ett program som ber användaren mata in en text.
Console.Write("Skriv en text: ");
string userInput = Console.ReadLine();
int userIntput = userInput.IndexOf(userInput);

//Be sedan användaren mata in en sträng som är en del av den första texten.
Console.Write("Skriv en del av din första text: ");
string partInput = Console.ReadLine();

if (userInput.Contains(partInput))
{
    string[] userInputParts = userInput.Split(partInput);

    string firstPart = userInputParts[0];
    string secondPart = userInputParts[1];

    Console.Write(firstPart );
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(partInput );
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write(secondPart);
}