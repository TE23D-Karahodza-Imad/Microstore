int playerMoney = 100;

while (playerMoney > 0)

{
    Console.WriteLine("Welcome to our Boxing Store, take a look around");
    Console.WriteLine($"You have {playerMoney} dollars");
    Console.WriteLine("Press ENTER to continue.");
    Console.ReadLine();

    Console.WriteLine("You take a look around and you come across black-green gloves, golden-red gloves and blue-yellow gloves. Which ones do you want to buy?");
    Console.WriteLine("Press ENTER to continue.");
    Console.ReadLine();

    Console.WriteLine("1. Black-Green gloves cost: 50$ ");
    Console.WriteLine("2. Blue-Yellow gloves cost: 70$ ");
    Console.WriteLine("3. Golden-Red gloves cost: 100$ ");
    

    string whatToBuy = "";
    while (whatToBuy != "1" && whatToBuy != "2" && whatToBuy != "3")
    {
    whatToBuy = Console.ReadLine();
    } 

  int pricePerItem = 0;

  if (whatToBuy == "1")
  {
    pricePerItem = 50;
  }
  else if (whatToBuy == "2")
  {
    pricePerItem = 70;
  }
  else if (whatToBuy == "3")
  {
    pricePerItem = 100;
  }

//---------------------------------------------//

  Console.WriteLine("How many pairs do you want to buy?");
  int numToBuy = 0;
  while (numToBuy == 0)
  {
    string num = Console.ReadLine();
    bool success = int.TryParse(num, out numToBuy);
    if (success == false)
    {
      Console.WriteLine("You must tell me how many!");
    }
  }

  int finalCost = pricePerItem * numToBuy;

  if (finalCost <= playerMoney)
  {
    Console.WriteLine("Yes that will be good.");
    playerMoney -= finalCost;
  }
  else
  {
    Console.WriteLine("Im sorry but you cant afford it..");
  }


Console.WriteLine("Now you are short on money.");
Console.WriteLine("Press ENTER to finish.");
Console.ReadLine();
} 

//-------------------------------------
Console.ReadLine();
    
