using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("                              iNheritance        ");
            Chef chef = new Chef();  //chef yra oblektas ir jis sukurtas naujai
            chef.MakeChicken();
            ItalianChef ItalianChef = new ItalianChef();
            ItalianChef.MakeChicken();
            ItalianChef.Makepasta();
            chef.MakeSpeciolDish();
            ItalianChef.MakeSpeciolDish(); // public virtuol void. ir override
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("                              Static Methods &Classes        ");
            Console.WriteLine(Math.Sqrt(144)); //static class negali iskviesti kaip naujos.
            // math yra Class o kas po tasko .SQRT yra petodas.
            UsefulTools.SayHi(" Mike"); //sukuriame tiesiogiai class be nusefultool = new....
            Console.ReadLine();
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("                              Static and public atributtes        ");
            Console.WriteLine(Song.songCount);
            Song holiday = new Song("Holiday", "Green Day", 200);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(Song.songCount);

            //Song holiday = new Song("Holiday", "Green Day", 20000);
            //Console.WriteLine(Song.songCount);
            //Song kashmir = new Song("Kashmir", "Led Zeppelin", 15000); 
            //static atributes tai yra unikalus atributas
            Console.WriteLine(new Song("Holiday", "Green Day", 200).nameName);
            Console.WriteLine(Song.songCount); //public statik belongs to the class not for value
            Console.WriteLine(kashmir.nameName);
            Console.WriteLine(new Song("Holiday", "Green Day", 200).number);
            Console.WriteLine(kashmir.number);
            Console.WriteLine(new Song("Holiday", "Green Day", 200).album);
            Console.WriteLine(kashmir.album);
            Console.WriteLine("kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk");
            Console.WriteLine(kashmir.getSongCount());
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("                              Getters & Setters        ");
            Movie avengersai = new Movie("The avengers", "Joss Whedon", "PG");
            Movie shrek = new Movie("shrek", "Joss Whedonas", "PG");
            // G, PG, PG-13, R, NR
            avengersai.Rating = "dog";

            Console.WriteLine(avengersai.Rating);
            Console.WriteLine(shrek.Rating);

            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("                              Object Methods        ");
            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);
            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("                              Constructors        ");
            FirstBook book1 = new FirstBook("Harry Poter", "As esu autorius", 400);
            book1.author = "Jams Bond agent 007";
            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);
            Console.WriteLine("-------------------");
            FirstBook book2 = new FirstBook("Ferrary", "Autorius yra KJLO", 700);
            book2.title = "The hobbit";
            Console.WriteLine(book2.title);
            Console.WriteLine(book2.author);
            Console.WriteLine(book2.pages);
            Console.WriteLine("-------------------");
            FirstBook book3 = new FirstBook("Nauja 3 knyga", "sukurta nauju metodu", 3);
            Console.WriteLine(book3.title);
            Console.WriteLine(book3.author);
            Console.WriteLine(book3.pages);
            Console.WriteLine("-------------------");
            FirstBook book4 = new FirstBook(); //galima sukurti be pavadinimo tam reikia first book padaryti public firstbook() be pavadinimo

            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("                              Classes & objects        ");
            /* FirstBook book1 = new FirstBook();
             book1.title = "Harry Poter";
             book1.author = "As esu autorius";
             book1.pages = 400;
             Console.WriteLine(book1.title );
             Console.WriteLine(book1.author);
             Console.WriteLine(book1.pages);
             FirstBook book2 = new FirstBook();
             book2.title = "Ferrary";
             book2.author = "autorius ";
             book2.pages = 700;
             Console.WriteLine(book2.title);
             Console.WriteLine(book2.author);
             Console.WriteLine(book2.pages );
            */

            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("                              Exception Handling        ");
            try
            {
                Console.WriteLine("write a number:...");
                int num100 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter second number:   ");
                int num200 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num100 / num200);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            /*  finally // programa vykdys visk1 kas finally irasyta
              {

              }

              /*    paprastasis budas kad i6mestu tiesiog zodeli error 
               catch
              {
                  Console.WriteLine("ERROR");
              }
              -------------------------------------------------------
               catch(DivideByZeroException e)     pagaus tik divideby zero klaida. visa kita nulau6 programa.
              {
                  Console.WriteLine(e.Message);
              }
              catch(FormatException e)            galima sugauti kiek nori 1 2 ar 3 zinutes ir jos iskils reikia prideti catch
              {
                  Console.WriteLine(e.Message);
              }

              */
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("                              2d Array        ");
            int[,] numberGrid = { // [,] pasako kad norim 2d array kuo daugiau dimensiju tuo daugiau kableliu [,,,,}
            {1, 2 },  // first element  prasideda nuo 0
                {3, 4 }, // second element tada eina 1
                {5, 6 } // third elementi ir eina kaip 2
            };
            Console.WriteLine(numberGrid[0, 0]); // noriu pasiekti pirmo elemento is array pirma skaiciu
            Console.WriteLine(numberGrid[1, 1]); // pasiekti skaiciu 4 ir antro elemento
            Console.WriteLine(numberGrid[2, 0]); // pasiekti numeri 5 is 3 elemento
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("                              Exponent Method        ");
            Console.WriteLine(GetPow(3, 5)); //tik su pliusiniais zenklais. su minusu neveikia...
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("                              For LOOP        ");
            int i = 1;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            for (int l = 1; l < 5; l++)//condition  we write 3 things 1 nusakom int = 1, tada condition, ir tekstas ka parasys
            {
                Console.WriteLine(l);
            }
            // gaunamas tas pats rezultatas tik reikia parasyti for tada koks tavo int tada taip pat kaip while parasyti condition kad int <uz kazka, ir parasyti kad kaskart padidetu per vieneta ar daugiau ++
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 }; // ray (konteinerio panaudojimas su for loop

            for (int g = 0; g < luckyNumbers.Length; g++)
            {
                Console.WriteLine(luckyNumbers[g]);
            }
            Console.WriteLine("------------------------------------------------------------------------");
            string atsakymas = "automobilis";
            string klausimas = "";
            int klausimuskaicius = 0;
            int limitas = 5;
            bool virsLimito = false;

            while (atsakymas != klausimas && !virsLimito) //kol nevirsytas limitas, atsakymas nera lygus klausimui
            {
                if (klausimuskaicius <= limitas)
                {
                    Console.WriteLine("Su kuo tu vaziuoji i darba?");
                    klausimas = Console.ReadLine();
                    klausimuskaicius++;
                }
                else
                {
                    virsLimito = true;
                }

            }
            if (virsLimito)
            {
                Console.WriteLine("Tupralaimejai");
            }
            else
            {
                Console.WriteLine("Tup laimejai");
            }

            while (atsakymas != klausimas)
            {
                Console.WriteLine("masina kitaip?");
                klausimas = Console.ReadLine();
                klausimuskaicius++;
            }
            Console.WriteLine("atspejai");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("                              The Guessing Game        ");
            string secretWord = "Namas";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGueses = false;
            while (guess != secretWord && !outOfGueses)
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine(" Enter your guess (Namas)");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGueses = true;
                }
            }
            if (outOfGueses)
            {
                Console.WriteLine("You Lose");
            }
            else
            {
                Console.WriteLine("You winer");
            }

            string zodis = "car";
            string klausk = "";
            int kartuskaicius = 0;
            int limitas3 = 5;
            bool spejimukartai = false;

            while (klausk != zodis && !spejimukartai) //kol zodis kuris irasomas nera lygus atsakymui ir nera lygus spejimo kartu kiekiui IF statmentui.
            {
                if (kartuskaicius < limitas3)
                {
                    Console.WriteLine("Zodis angliskai \"automobilis\"");
                    klausk = Console.ReadLine();
                    kartuskaicius++;
                }
                else
                {
                    spejimukartai = true;
                }
                if (spejimukartai)
                {
                    Console.WriteLine(" Pralaimejai nes perdaug bandymu");
                }
                else
                {
                    Console.WriteLine("Tu nugaletojas");
                }
            }

            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("                              While Loop        ");
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }
            Console.WriteLine("                              Do While Loop        ");//atlieka pirma komanda pries patikrindamas condition
            int index2 = 6;
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index2 <= 5); ;
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("                              switch statment        ");
            Console.WriteLine(GetDay(5));
            Console.WriteLine(GetDay(0));
            Console.WriteLine(GetDay(4));
            Console.WriteLine(GetDay(6));
            Console.WriteLine(GetDay(50));

            Console.WriteLine("------------------------------------------------------------------------");


            Console.WriteLine("Witch number is bigger Palyginimas 2 ar 15 ??");
            Console.WriteLine(GetMax(2, 15));
            Console.WriteLine("Witch number is bigger Palyginimas 2 ar 15 ar 50 ??");
            Console.WriteLine(GettwoMax(2, 15, 50));
            Console.WriteLine("                      Calculator");
            Console.Write("Enter a number:  ");
            double num10 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Operator:   ");
            string op = Console.ReadLine();
            Console.Write("Enter second a number:  ");
            double num20 = Convert.ToDouble(Console.ReadLine());
            if (op == "+")
            {
                Console.Write(num10 + num20);
            }
            else if (op == "-")
            {
                Console.Write(num10 - num20);
            }
            else if (op == "/")
            {
                Console.Write(num10 / num20);
            }
            else if (op == "*")
            {
                Console.Write(num10 * num20);
            }
            else
            {
                Console.Write("Invalid Operator");
            }
            Console.WriteLine("                                      ");
            Console.WriteLine("                              ********************        ");
            string characterName = "John";
            int characterage;
            characterage = 35;
            Console.WriteLine("There once was a man named John" + characterName + characterage);
            Console.WriteLine("nauja linija ------------------ " + characterName + "-----------------------------");
            Console.WriteLine("He was 35 years old");
            characterName = "Johnnnnn";
            characterage = 25;
            Console.WriteLine("He really like the name" + characterName);
            Console.WriteLine("but he didn't like being 35" + characterName + characterage);
            Console.WriteLine("                   ******                         ");
            string vardas = "Loop";
            Console.WriteLine(vardas + " is going to store");
            Console.WriteLine(vardas + " would like to buy some grosores");
            Console.WriteLine("he want to buy\n the apple cost 50 ct,\n orange 1.25 eu,\n milk cost 1 eu");
            Console.WriteLine("Tom in his pcket have 2.5 eu");
            Console.WriteLine("is it true that Tom have enouht money for all his grosoreas?");
            Console.WriteLine("                          ***********                       ");
            Console.WriteLine("                          ***********                       ");
            Console.WriteLine("                          ***********                       ");
            Console.Write("What is your name?  ");
            string user = Console.ReadLine();
            Console.WriteLine("Hello" + user);
            Console.WriteLine("do you want to change the story?:   ");
            string choise = Console.ReadLine();
            string color, name, age;
            Console.Write("Enter a color: ");
            color = Console.ReadLine();
            Console.Write("Enter a Name: ");
            name = Console.ReadLine();
            Console.Write("Enter a Age: ");
            age = Console.ReadLine();
            Console.WriteLine(name + " is going to store");
            Console.WriteLine(name + "is" + age + "years old");
            Console.WriteLine(name + " would like to buy some grosores");
            Console.WriteLine("he want to buy\n the apple cost 50 ct,\n orange 1.25 eu,\n milk cost 1 eu");
            Console.WriteLine(name + " in his pocket have 2.5 eu");
            Console.WriteLine("is it true that Tom have enouht money for all his grosoreas?");
            Console.WriteLine("                          ***********                       ");
            Console.WriteLine("                          ***********                       ");
            Console.WriteLine("                                                  ");
            Console.WriteLine(user + " in his left pocket kas 45 euros");
            Console.WriteLine(user + " in his right pocket kas 5.5 euros");
            Console.WriteLine("Lest calculate how many euros do you " + user + " have in his pocket");
            Console.Write("Enter how many euros is in left pocket    ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter how many euros is in right pocket    ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("and the answer is................");
            Console.WriteLine(num1 + num2);
            Console.WriteLine("1                    1");
            Console.WriteLine("2                      1");
            Console.WriteLine("1                           j  3                     1");
            Console.WriteLine("Roses are{color}");
            Console.WriteLine("                          ***********                       ");
            Console.WriteLine("Samsung s20 min price ");
            Console.WriteLine("                          If statement   Ice cream                     ");
            Console.WriteLine("Is you Tall man??? If statment quastion");
            bool isMale = true;
            bool isTall = false;
            if (isMale && isTall)
            {
                Console.WriteLine("You are Male and tall");
            }
            if (isMale || isTall)
            {
                Console.WriteLine("You are Male and tall");
            }
            else if (isMale)
            {
                Console.WriteLine("You are Male");
            }
            else if (!isTall)
            {
                Console.WriteLine("You are Not male");
            }
            else
            {
                Console.WriteLine("You are not male not tall");
            }
            Console.WriteLine("                          If statement No2   Ice cream                     ");
            Console.WriteLine("                          ***********                       ");
            Console.WriteLine("If you want icecream pleas thoose \"Yes\",\n if you don't want type \"No\" \n If you don't know please type \"maybe\" ");
            bool yes = true;
            bool no = false;
            bool maybe = false;
            if (yes)
            {
                Console.WriteLine("You choose Yes that meens you need to stand up and go to your fridge!!! ");
            }
            else if (no || maybe)
            {
                Console.WriteLine("just relax and wait for dinner time");
            }
            else if (!yes)
            {
                Console.WriteLine("please write Yes No or Maybe");
            }
            else
            {
                Console.WriteLine("Write NO YES MAYBE");
            }

            Console.ReadLine();
        }
        static int GetMax(int num1, int num2)
        {
            int result;
            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }

            return result;
        }
        static int GettwoMax(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 > num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }
            return result;

        }
        static string GetDay(int dayNum)
        {
            string dayName;
            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Mondey";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wensday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }
            return dayName;
        }
        static int GetPow(int baseNum, int PowNum)
        {
            int result = 1;
            for (int f = 0; f < PowNum; f++)
            {
                result = result * baseNum;
            }
            return result;
        }
    }

}
