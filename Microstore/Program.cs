int playerMoney = 100;

while (playerMoney > 0)

{
    Console.WriteLine("Welcome to our Boxing Store, take a look around");
    Console.WriteLine($"You have {playerMoney} dollars left");

    Console.WriteLine("You take a look around and you come across black-green gloves, golden-red gloves and blue-yellow gloves. Which ones do you want to buy?");
    Console.WriteLine("Black-Green gloves cost: 50$ ");
    Console.WriteLine("Blue-Yellow gloves cost: 70$ ");
    Console.WriteLine("Golden-Red gloves cost: 100$ ");
    



    string whatToBuy = "";
    while (whatToBuy != "1" && whatToBuy != "2" && whatToBuy != "3")
    {
    whatToBuy = Console.ReadLine();
    } 

  int pricePerItem = 0;

  if (whatToBuy == "1")
  {
    pricePerItem = 10;
  }
  else if (whatToBuy == "2")
  {
    pricePerItem = 20;
  }
  else if (whatToBuy == "3")
  {
    pricePerItem = 30;
  }

  // Hur många man vill köpa

  Console.WriteLine("Hur många vill du köpa?");
  int numToBuy = 0;
  while (numToBuy == 0)
  {
    string num = Console.ReadLine();
    bool success = int.TryParse(num, out numToBuy);
    if (success == false)
    {
      Console.WriteLine("Du måste skriva en siffra!");
    }
  }

  int finalCost = pricePerItem * numToBuy;

  if (finalCost <= playerMoney)
  {
    Console.WriteLine("Ja, det går bra.");
    playerMoney -= finalCost;
  }
  else
  {
    Console.WriteLine("Nej, det har du inte råd med!");
  }


Console.WriteLine("Nu har du slut på pengar!");
Console.WriteLine("Tryck på ENTER för att avsluta");
Console.ReadLine();
} 

//-------------------------------------
Console.ReadLine();
    
