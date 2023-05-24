using System;

namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Movies batman = new Movies("BatMan", "slh1", "123");
            Movies test = new Movies("test", "slh2", "12340");

            //struct Movie {
            //string batman;
            //string matrix; 
            //};

            batman.movieId= "abc";

            Console.WriteLine(batman.movieId);
            Console.WriteLine(test.movieId);

            Console.ReadLine();

            //Object METHODS 

            //Students student1 = new Students("slh", 28, 2.5);
            //Students student2 = new Students("ala", 20, 3.9);


            //Console.WriteLine("Student 1 has hornor : " + student1.Honnor());
            //Console.WriteLine("Student 2 has hornor : " + student2.Honnor());
            //Console.ReadLine(); 

            //Constructor 

            //Book book1 = new Book("test" , "slh" , 200);
            //Book book2 = new Book("test2", "slh1122", 400);

            //book2.Title= "Test123455";

            //Console.WriteLine(book1.Title);
            //Console.WriteLine(book2.Title);
            //Console.ReadLine();

            //Create a New Class

            //Book book1 = new Book();
            //book1.Title = "Test";
            //book1.Author = "slh";
            //book1.Pages = 200;

            //Book book2 = new Book();
            //book2.Title = "test2";
            //book2.Author = "slh123";
            //book2.Pages = 500;
            //int test = book2.MinusPages(book2.Pages);

            //Console.WriteLine(book1.Title + " " + book1.Author + " " + book1.Pages);
            //Console.WriteLine(test);
            //Console.ReadLine();

            //try AND CATCH
            //try
            //{
            //    Console.Write("enter a number");
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("enter a number");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(num1 / num2);
            //}
            //catch(DivideByZeroException ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            ////finally { Console.WriteLine("User Error 400")};
            //Console.ReadLine();






            //int[,] numberGrid = {
            //    {1,2 },
            //    {3,4 },
            //    {5,6 }
            //};

            //int[,] myArray = new int[2, 1];

            //colunm
            //myArray[0, 0] = 1;
            //myArray[1, 0] = 2;
            //myArray[2, 0] = 3;
            //row
            //myArray[0, 1] = 4;
            //myArray[1, 1] = 5;
            //myArray[2, 1] = 6;

            //Console.WriteLine(myArray[1, 0]);
            //Console.WriteLine(numberGrid[2, 1]);
            //Console.ReadLine();
            //POW FUNC
            //Console.WriteLine(GetPow(3, 3));
            //Console.ReadLine();

            //FOR
            //int i = 0;
            //string str = "hello!";
            //int[] numbers = {1,5,3,6,7}; 
            //for (i=0;i<str.Length;i++)
            //{
            //    Console.WriteLine(numbers[i]);

            //    Console.WriteLine(str[i]);
            //    Console.WriteLine(i);
            //}

            //Console.ReadLine();

            //WHILE
            //string secretWord = "6";
            //string guess = "";
            //int guessCount = 0;
            //int limitGuess = 3;
            //bool outOfGuesses = false;

            //while (guess != secretWord && !outOfGuesses)
            //{
            //    if (guessCount < limitGuess)
            //    {
            //        Console.Write("enter guess : ");
            //        guess = Console.ReadLine();
            //        guessCount++;
            //    }
            //    else
            //    {
            //        outOfGuesses=true;
            //    }

            //}
            //if(outOfGuesses)
            //{
            //    Console.Write("you lose");
            //}
            //else
            //{
            //    Console.Write("you win");
            //}

            //Console.ReadLine();

            //SWITCH CASE
            //static string GetDay(int dayNum)
            //{
            //     string dayName;
            //    switch (dayNum)
            //    {
            //        case 0:
            //            dayName = "sunday";
            //            break;
            //        case 1:
            //            dayName = "monday";
            //            break;
            //        case 2:
            //            dayName = "thersday";
            //            break;
            //        case 3:
            //            dayName = "hello";
            //            break;
            //        case 4:
            //            dayName = "hi";
            //            break;
            //        case 5:
            //            dayName = "test";
            //            break;
            //        default:
            //            dayName = "not found";
            //            break;

            //    }
            //    return dayName;
            //}

        }
        //POW FUNC
        //static int GetPow(int baseNum , int powNum) {
        //    int result = 1;

        //    for (int i = 0; i < powNum; i++)
        //    {
        //        result = result * baseNum;
        //    }

        //    return result;
        //}
    }
}
