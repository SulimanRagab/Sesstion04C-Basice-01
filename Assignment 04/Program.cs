
#region Q01
//Requirements
//Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print
//the second price (index 1).
//double[] prices = { 25.5, 40.0, 33.75 };
//Console.WriteLine(prices[1]);
#endregion

#region Q02
//Requirements
//Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
//shelf 1 has 1, 4 copies. Print the number of copies on shelf 1, slot 0.
//int[,] shelfCopies =
//{
//{3,5},
//{1,4}
//};
//Console.WriteLine(shelfCopies[0,1]); //  Print   5
#endregion

#region Q03
//Requirements
//Write a method called PrintWelcomeMessage that takes no parameters and prints
//"Welcome to the Library!".Call it from Main.
//main();
//void main()
//{
//    PrintWelcomeMessage();
//}
//void PrintWelcomeMessage()
//{
//    Console.WriteLine("Welcome to the Library!");
//}
#endregion

#region Q04
//Requirements
//Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
//"Clean Code".
//
//PrintBookTitle("Clean Code او اي حاجه من استريينج");
//void PrintBookTitle(string title)
//{
//    Console.WriteLine($"Book title: {title}"); // Book title: Clean Code او اي حاجه من استريينج
//}

#endregion

#region Q05
////Requirements
//
//void AddBonusPages(int x)
//{
//    x = x + 50;
//    Console.WriteLine(x); // هنا استقبلت نسخه من قيمة المتغير  وزودت عليه 50  ف اصبح النات 350    وقيمة المتغير الاصلي م اتغيرتش لسه زي م هيا 
//}
//int pages = 300;
//  خاص بسؤال رقم 7
//Console.WriteLine(pages);
//AddBonusPagesByRef(ref pages);
//Console.WriteLine($" after method : pages = {pages}");
// الميثود لما استقبلت  ب  ref  غيرت ف اصل قيمة المتغير مش اخدت منه نسخه 

//AddBonusPages(pages);
//Console.WriteLine(pages); // هنا القيمه  ب 300 لأن الميثود م غيرتش اصل قيمة المتغير
#endregion

#region Q06
//Requirements
// Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it with
//double[] prices = { 25.5, 40.0 };
//  جزء خاص بسؤال رقم 8
//Console.WriteLine("valueArray Befoor");
//foreach (double beforPrices in prices)
//{
//    Console.WriteLine(beforPrices);
//}
//Console.WriteLine("lenth befor value");
//Console.WriteLine("   ");
//Console.WriteLine(prices.Length);
//Console.WriteLine("print after cal method");
//Console.WriteLine("   ");
//ReplaceArray(ref prices);
//

//; and print prices[0] afterward. What do you expect to
//see, and why?

//double[] prices = { 25.5, 40.0 };
//ApplyDiscount(prices);
//Console.WriteLine(prices[0]);
//void ApplyDiscount(double[] pric)
//{
//    pric[0] = pric[0] - 5;

//    Console.WriteLine(pric[0]);

//} 
//Console.WriteLine("after Array Edit"); 
//foreach (double price in prices)
//{
//    // اتوقع قبل الطباعه ان  prices[0]  اللي قيمتها ف الاصل 25.5 هتبقى 20.5 لأن الميثود بتغير ف اصل قيمة ال Ref

//    Console.WriteLine(price);
//}
#endregion

#region Q07
//Requirements
//Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
//Call it and print pages afterward. How is the result different from question 5?
//void AddBonusPagesByRef(ref int pages)
//{
//    pages = pages + 100;
//}

#endregion

#region Q08
//Requirements
// Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
//new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length
//afterward.

//void ReplaceArray(ref  double[] prices)
//{
//     prices = new double[] { 10.0, 12.5, 15.0 };
//    Console.WriteLine("after array lenth");
//    Console.WriteLine("   ");
//    Console.WriteLine(prices.Length);
//    Console.WriteLine("valueee");
//    Console.WriteLine("   ");
//    foreach (double Arrayvalue in prices)
//    {
//        Console.WriteLine(Arrayvalue);
//    }
//}
// كدا ال Array القديمه لسه موجوده ف الذاكره و Garbage هيشتغل ويمسحها 
#endregion

#region Q09
//Requirements
//Write a method bool TryGetPrice(string title, out double price) that returns true and sets
//price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0. Call it
  
//bool TryGetPrice(string title, out double price)
//{
//    if(title == "Clean Code")
//    {
//        price = 25.5;
//        return true;
//    }
//    else
//    {
//        price = 0; 
//       return false;
//    }
//}
//double price;
//string bookname;
//do
//{
//bookname = Console.ReadLine();
//    TryGetPrice(bookname, out  price);
//    Console.WriteLine(price);
//} while (bookname != "Clean Code");



#endregion