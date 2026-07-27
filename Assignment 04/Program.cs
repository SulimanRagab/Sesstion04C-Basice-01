
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
//AddBonusPages(pages);
//Console.WriteLine(pages); // هنا القيمه  ب 300 لأن الميثود م غيرتش اصل قيمة المتغير
#endregion

#region Q06
//Requirements
// Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
//with double[] prices = { 25.5, 40.0 }
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

