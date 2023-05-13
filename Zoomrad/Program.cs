namespace Card
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("         -----------");
            Console.WriteLine("         | ZOOMRAD |");
            Console.WriteLine("         -----------");


            Console.ForegroundColor = ConsoleColor.Blue;
            Kashbak cart = new Kashbak();
            cart.start();
            cart.Face();
        }
        public class Kashbak
        {
            public int Keshbek { get; set; }
            public string Jamgarma { get; set; }
            public string Omonatlar { get; set; }
            public int Kreditlar { get; set; }
            public decimal Balans = 50000000;
            public int Score = 0;
            public decimal Savings;
            public int Deposits;
            public int Loans;
            public int Cash = 0;


            public Kashbak()
            {
                Keshbek = 0;
                Jamgarma = string.Empty;
                Omonatlar = string.Empty;
                Kreditlar = 0;
                Balans = 50000000;
                Score = 1;
                Savings = 1;
                Deposits = 1;
                Loans = 1;
            }
            public void start()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("     ^ You code enter: ");
                int cod = int.Parse(Console.ReadLine());
                if (cod == 1111)
                {
                    GetLanguage();
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("     ^ | Eror you  code  try again! |  ");
                }

                start();
            }
            public void GetLanguage()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("     ^ 1. ENG ");
                Console.WriteLine("     ^ 2. RUS ");
                Console.WriteLine("     ^ 3. UZB ");
                Console.Write("     ^ => ");
                int lenguage = int.Parse(Console.ReadLine());

                if (lenguage == 1)
                {
                    Face();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("     ^ Please try again!  Have not Language now!");
                    GetLanguage();
                }
            }
            public void Face()
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("           ________________ ");
                Console.WriteLine($"     ^ Your Balanse:    |  {Balans} |");
                Console.WriteLine("           _________________");
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("     ^|%|^            ---------------------------------------               ^|%|^                            ");
                Console.WriteLine($"     ^|%|^            | 1. SCORE  {Score} |        | 2. SAVINGS  {Savings} |              ^|%|^        ");
                Console.WriteLine("     ^|%|^            ---------------------------------------               ^|%|^                            ");

                Console.WriteLine("     ^|%|^            ---------------------------------------               ^|%|^                             ");
                Console.WriteLine($"     ^|%|^            | 3. DEPOSITS  {Deposits} |        | 4. LOANS  {Loans} |             ^|%|^     ");
                Console.WriteLine("     ^|%|^            ----------------------------------------              ^|%|^                             ");

                Console.Write(" =>");
                int facenum = int.Parse(Console.ReadLine());
                if (facenum == 1)
                {
                    Ball();
                }
                if (facenum == 2)
                {
                    Saving();
                }
                if (facenum == 3)
                {
                    Deposit();
                }
                if (facenum == 4)
                {
                    Loanz();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("     ^ Your Number Enter Eror  Try Again !");
                    Face();
                }
            }

            public int Return()
            {
                return 0;
            }
            public void Ball()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("     ^              |*   Ball  condition of receipt!   *|");
                Console.WriteLine("     ^              |  1. Transfer money from carta to carta   |       |    2 000  so'm = 1 ball  | ");
                Console.WriteLine("     ^              |  2. Loan repayment                       |       |    2 000  so'm = 1 ball   | ");
                Console.WriteLine("     ^              |  3. All other shoorts                    |       |   1 000  so'm = 1 ball   | ");
                Console.Write("     ^ => ");
                int ball = int.Parse(Console.ReadLine());
                if (ball == 1)
                {
                    Transfer();
                }
                if (ball == 2)
                {
                    Loan();
                }
                if (ball == 3)
                {
                    All();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("     ^ Try Again! ");
                    Ball();
                }

            }

            public void Transfer()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                int cash = 0;
                Console.Write("     ^ Enter Summa : ");
                int summa = int.Parse(Console.ReadLine());
                if (summa > 2000)
                {
                    Cash = summa / 2000;
                    Score = Cash;
                    Console.WriteLine($"     ^ Your Cash  {Cash}  so'm \n ");
                Mistake:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("     ^ 1. Go black  ");
                    Console.WriteLine("     ^ 0. Exit  ");
                    Console.Write("     ^ => ");
                    int value = int.Parse(Console.ReadLine());
                    if (value == 1)
                    {
                        Face();
                    }
                    if (value == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("     ^ Thenk You !!!!! ");
                        start();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("     ^ Your Enter  Number Mistake Try Again ! ");
                        goto Mistake;
                    }
                }
            }
            public void Loan()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                int cash = 0;
                Console.Write("     ^ Enter Summa : ");
                int summa = int.Parse(Console.ReadLine());
                if (summa > 2000)
                {
                    Cash = summa / 2000;
                    Score = Cash;
                    Console.WriteLine($"     ^ Your Cash {Cash} so'm \n");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                Mistake:
                    Console.WriteLine("     ^ 1. Go black  ");
                    Console.WriteLine("     ^ 0. Exit  ");
                    Console.Write("     ^ => ");
                    int value = int.Parse(Console.ReadLine());
                    if (value == 1)
                    {
                        Face();
                    }
                    if (value == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("     ^ Thenk You !!!!! ");
                        start();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("     ^ Your Enter  Number Mistake Try Again ! ");
                        goto Mistake;
                    }
                }
            }
            public void All()
            {

                int cash = 0;
                Console.Write("    ^ Enter Summa : ");
                int summa = int.Parse(Console.ReadLine());
                if (summa > 1000)
                {
                    Cash = summa / 1000;
                    Score = Cash;
                    Console.WriteLine($" Your cash {Cash}  so'm \n ");
                Mistake:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("     ^ 1. Go black  ");
                    Console.WriteLine("     ^ 0. Exit  ");
                    Console.Write("     ^ => ");
                    int value = int.Parse(Console.ReadLine());
                    if (value == 1)
                    {
                        Face();
                    }
                    if (value == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("     ^ Thenk You !!!!! ");
                        start();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("     ^ Your Enter  Number Mistake Try Again ! ");
                        goto Mistake;
                    }
                }
            }

            public void Saving()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("     ^ What purpose do you want to eat? ");
                Console.WriteLine("                      _____________           ________________      ");
                Console.WriteLine("                     |  1. Market   |        | 2. To Me       |      ");
                Console.WriteLine("                     |  3. Trevel   |        | 4. Education   |      ");
                Console.WriteLine("                     |  5. Spare    |        | 6. Avtomobile  |      ");
                Console.WriteLine("                      _____________           ________________       ");
                Console.Write("     ^ => ");
                int savingsum = int.Parse(Console.ReadLine());
                if (savingsum == 1)
                {

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("     ^ Enter Shop Name: ");
                    string Shop = Console.ReadLine();
                    Console.Write("     ^ Enter Collection  Month Time: ");
                    int collectoin = int.Parse(Console.ReadLine());
                Zero:
                    Console.Write("     ^ Enter Collectoin Summa: ");
                    int summa = int.Parse(Console.ReadLine());
                    if (summa > 1000)
                    {
                        Balans = Balans - summa;
                        Savings = Savings + summa;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("     ^ Your Enter Value Less Than Zero  Try Again ! ");
                        goto Zero;
                    }
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"     ^ Your  Choose  Shop Name {Shop} ! ");
                    Console.WriteLine($"     ^ Your Mpney Choose Time {collectoin} !");
                    Console.WriteLine($"     ^ Your Choose Summa {summa} !");
                    Console.WriteLine("     ^ The Selected Actions Have Been Completed !!! ");
                Mistake:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("     ^ 1. Go black  ");
                    Console.WriteLine("     ^ 0. Exit  ");
                    Console.Write("     ^ => ");
                    int value = int.Parse(Console.ReadLine());
                    if (value == 1)
                    {
                        Face();
                    }
                    if (value == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("     ^ Thenk You !!!!! ");
                        start();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("     ^ Your Enter  Number Mistake Try Again ! ");
                        goto Mistake;
                    }
                }
                if (savingsum == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("     ^ Enter Something Name: ");
                    string something = Console.ReadLine();
                    Console.Write("     ^ Enter Collection Month Time: ");
                    int collectoin = int.Parse(Console.ReadLine());
                Zero:
                    Console.Write("     ^ Enter Collectoin Summa: ");
                    int summa = int.Parse(Console.ReadLine());
                    if (summa > 1000)
                    {
                        Balans = Balans - summa;
                        Savings = Savings + summa;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("     ^ Your Enter Value Less Than Zero  Try Again ! ");
                        goto Zero;
                    }
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"     ^ Your  Choose   Name {something} ! ");
                    Console.WriteLine($"     ^ Your Money Choose Time {collectoin} !");
                    Console.WriteLine($"     ^ Your Choose Summa {summa} !");
                    Console.WriteLine("     ^ The Selected Actions Have Been Completed !!! ");
                Mistakes:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("     ^ 1. Go black  ");
                    Console.WriteLine("     ^ 0. Exit  ");
                    Console.Write("     ^ => ");
                    int value = int.Parse(Console.ReadLine());
                    if (value == 1)
                    {
                        Face();
                    }
                    if (value == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("     ^ Thenk You !!!!! ");
                        start();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("     ^ Your Enter  Number Mistake Try Again ! ");
                        goto Mistakes;
                    }
                }
                if (savingsum == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("     ^ Enter Trevel Name: ");
                    string trevel = Console.ReadLine();
                    Console.Write("     ^ Enter Money Collection  Month Time: ");
                    int collectoin = int.Parse(Console.ReadLine());
                Zero:
                    Console.Write("     ^ Enter Collectoin Summa: ");
                    int summa = int.Parse(Console.ReadLine());
                    if (summa > 1000)
                    {
                        Balans = Balans - summa;
                        Savings = Savings + summa;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("     ^ Your Enter Value Less Than Zero  Try Again ! ");
                        goto Zero;
                    }
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"     ^ Your  Choose  Trevel Name {trevel} ! ");
                    Console.WriteLine($"     ^ Your Choose Time {collectoin} !");
                    Console.WriteLine($"     ^ Your Choose Summa {summa} !");
                    Console.WriteLine("     ^ The Selected Actions Have Been Completed !!! ");
                Mistaked:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("     ^ 1. Go black  ");
                    Console.WriteLine("     ^ 0. Exit  ");
                    Console.Write("     ^ => ");
                    int value = int.Parse(Console.ReadLine());
                    if (value == 1)
                    {
                        Face();
                    }
                    if (value == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("     ^ Thenk You !!!!! ");
                        start();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("     ^ Your Enter  Number Mistake Try Again ! ");
                        goto Mistaked;
                    }
                }
                if (savingsum == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("     ^ Enter Education Name: ");
                    string education = Console.ReadLine();
                    Console.Write("      ^ Enter Money  Collection Month  Time: ");
                    int collectoin = int.Parse(Console.ReadLine());
                Zero:
                    Console.Write("     ^ Enter Collectoin Summa: ");
                    int summa = int.Parse(Console.ReadLine());
                    if (summa > 1000)
                    {
                        Balans = Balans - summa;
                        Savings = Savings + summa;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("     ^ Your Enter Value Less Than Zero  Try Again ! ");
                        goto Zero;
                    }
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"     ^ Your  Choose  Education Name {education} ! ");
                    Console.WriteLine($"     ^ Your  Choose Time {collectoin} !");
                    Console.WriteLine($"     ^ Your Choose Summa {summa} !");
                    Console.WriteLine("     ^ The Selected Actions Have Been Completed !!! ");
                Eror:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("     ^ 1. Go black  ");
                    Console.WriteLine("     ^ 0. Exit  ");
                    Console.Write("     ^ => ");
                    int value = int.Parse(Console.ReadLine());
                    if (value == 1)
                    {
                        Face();
                    }
                    if (value == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("     ^ Thenk You !!!!! ");
                        start();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("     ^ Your Enter  Number Mistake Try Again ! ");
                        goto Eror;
                    }
                }
                if (savingsum == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("     ^ Enter Avtomobile  Name: ");
                    string something = Console.ReadLine();
                    Console.Write("     ^ Enter Collection  Month Time: ");
                    int collectoin = int.Parse(Console.ReadLine());
                Zero:
                    Console.Write("     ^ Enter Collectoin Summa: ");
                    int summa = int.Parse(Console.ReadLine());
                    if (summa > 1000)
                    {
                        Balans = Balans - summa;
                        Savings = Savings + summa;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("     ^ Your Enter Value Less Than Zero  Try Again ! ");
                        goto Zero;
                    }
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"     ^ Your  Choose  Avtomobile  Name {something} ! ");
                    Console.WriteLine($"     ^ Your Choose Time {collectoin} !");
                    Console.WriteLine($"     ^ Your Choose Summa {summa} !");
                    Console.WriteLine("     ^ The Selected Actions Have Been Completed !!! ");
                Mast:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("     ^ 1. Go black  ");
                    Console.WriteLine("     ^ 0. Exit  ");
                    Console.Write("     ^ => ");
                    int value = int.Parse(Console.ReadLine());
                    if (value == 1)
                    {
                        Face();
                    }
                    if (value == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("     ^ Thenk You !!!!! ");
                        start();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("     ^ Your Enter  Number Mistake Try Again ! ");
                        goto Mast;
                    }
                }
                if (savingsum == 6)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("     ^ Enter For Something  Name: ");
                    string something = Console.ReadLine();
                    Console.Write("      ^ Enter Collection Month Time: ");
                    int collectoin = int.Parse(Console.ReadLine());
                Zero:
                    Console.Write("     ^ Enter Collectoin Summa: ");
                    int summa = int.Parse(Console.ReadLine());
                    if (summa > 1000)
                    {
                        Balans = Balans - summa;
                        Savings = Savings + summa;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("     ^ Your Enter Value Less Than Zero  Try Again ! ");
                        goto Zero;
                    }
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"     ^ Your  Choose  For Something  Name {something} ! ");
                    Console.WriteLine($"     ^ Your Choose Time {collectoin} !");
                    Console.WriteLine($"     ^ Your Choose Summa {summa} !");
                    Console.WriteLine("     ^ The Selected Actions Have Been Completed !!! ");
                Mistaked:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("     ^ 1. Go black  ");
                    Console.WriteLine("     ^ 0. Exit  ");
                    Console.Write("     ^ => ");
                    int value = int.Parse(Console.ReadLine());
                    if (value == 1)
                    {
                        Face();
                    }
                    if (value == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("     ^ Thenk You !!!!! ");
                        start();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("     ^ Your Enter  Number Mistake Try Again ! ");
                        goto Mistaked;
                    }
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("     ^ Eror Your Number      Try Again!    ");
                    Saving();
                }

            }

            public void Deposit()
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("     ^  ____________________________ ");
                Console.WriteLine("     ^ | 1. Magnetic Plus   1 000 000 so'm     { 3-6 month}   18%         |");
                Console.WriteLine("     ^  ____________________________ ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("     ^  ____________________________ ");
                Console.WriteLine("     ^ | 2. Comfort Online 10 000 000 so'm   { 12-18 month}   22%     |");
                Console.WriteLine("     ^  ____________________________ ");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("     ^  ____________________________ ");
                Console.WriteLine("     ^ | 3. One   Annual    50 000 000 so'm   { 18-24  month}   28%     |");
                Console.WriteLine("     ^  ____________________________ ");
                Console.Write("     ^ => ");
                int deposit = int.Parse(Console.ReadLine());
                if (deposit == 1)
                {
                Moon:
                    Deposits = Deposits + 1;
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("     ^ | Enter Month: ");
                    int month = int.Parse(Console.ReadLine());
                    if (month >= 3 && month < 7)
                    {
                    Sama:
                        Console.Write("     ^ | Enter Summa: ");
                        int summa = int.Parse(Console.ReadLine());
                        if (summa < Balans && summa > 100000)
                        {
                            Balans = Balans - summa;
                            int som = summa % 18;
                            som = som * 10000;
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine($"     ^ Your Enter Summa {summa} ");
                            Console.WriteLine($"     ^ Your Enter Month  {month} To  ");
                            Console.WriteLine($"     ^ {som}% Is Saved For You !!! ");
                        Mistake:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("     ^ 1. Go black  ");
                            Console.WriteLine("     ^ 0. Exit  ");
                            Console.Write("     ^ => ");
                            int value = int.Parse(Console.ReadLine());
                            if (value == 1)
                            {
                                Face();
                            }
                            if (value == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("     ^ Thenk You !!!!! ");
                                start();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("     ^ Your Enter  Number Mistake Try Again ! ");
                                goto Mistake;
                            }

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("    ^ The Amount is Enough  Try Again !");
                            goto Sama;
                        }

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("    ^ Eror number  Try again ! ");
                        goto Moon;
                    }
                }

                if (deposit == 2)
                {
                Moon1:
                    Deposits = Deposits + 1;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("     ^ | Enter Month: ");
                    int month = int.Parse(Console.ReadLine());
                    if (month >= 12 && month < 19)
                    {
                    Sama1:
                        Console.Write("    ^ | Enter Summa: ");
                        int summa2 = int.Parse(Console.ReadLine());
                        if (summa2 < Balans && summa2 > 1000000)
                        {
                            Balans = Balans - summa2;
                            int som1 = summa2 % 22;
                            som1 = som1 * 10000;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"     ^ Your Enter Summa {summa2} ");
                            Console.WriteLine($"     ^ Your Enter Month  {month} To  ");
                            Console.WriteLine($"     ^ {som1}% Is Saved For You !!! ");

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("     ^ 1. Go black  ");
                            Console.WriteLine("     ^ 0. Exit  ");
                            Console.Write("     ^ => ");
                            int value = int.Parse(Console.ReadLine());
                            if (value == 1)
                            {
                                Face();
                            }
                            if (value == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("     ^ Thenk You !!!!! ");
                                start();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("    ^ The Amount is Enough  Try Again !");
                            goto Sama1;
                        }

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("    ^ Eror number  Try again ! ");
                        goto Moon1;
                    }
                }


                if (deposit == 3)
                {
                Moon1:
                    Deposits = Deposits + 1;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("     ^ | Enter Month: ");
                    int month = int.Parse(Console.ReadLine());
                    if (month >= 18 && month < 25)
                    {

                        Console.Write("    ^ | Enter Summa: ");
                        int summa3 = int.Parse(Console.ReadLine());
                        if (summa3 < Balans && summa3 > 10000000)
                        {
                            Balans = Balans - summa3;
                            int som3 = summa3 % 28;
                            som3 = som3 * 10000;
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine($"     ^ Your Enter Summa {summa3} ");
                            Console.WriteLine($"     ^ Your Enter Month  {month} To  ");
                            Console.WriteLine($"     ^ {som3}% Is Saved For You !!! ");

                        Mistake:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("     ^ 1. Go black  ");
                            Console.WriteLine("     ^ 0. Exit  ");
                            Console.Write("     ^ => ");
                            int value = int.Parse(Console.ReadLine());
                            if (value == 1)
                            {
                                Face();
                            }
                            if (value == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("     ^ Thenk You !!!!! ");
                                start();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("     ^ Your Enter  Number Mistake Try Again ! ");
                                goto Mistake;
                            }
                        }
                    }


                }
            }
            public void Loanz()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("     ^  ___________");
                Console.WriteLine($"     ^ | Your Loans {Loans} ! | ");
                Console.WriteLine("     ^  ___________");
                Console.WriteLine("     ^ 1. Get Loan Now  ");
                Console.WriteLine("     ^ 2. Price Loan Know   ");
                Console.WriteLine("     ^ 0. Exite    ");
                Console.Write("     ^ => ");
                int loans = int.Parse(Console.ReadLine());
                if (loans == 1)
                {
                    Loans = Loans + 1;
                    Console.Write("     ^ Enter  Your Get Summa:  ");
                    int getsum = int.Parse(Console.ReadLine());
                    Balans = Balans + getsum;
                    Console.WriteLine($"     ^ Loan   Received {getsum} Summa !!!");

                Mistake:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("     ^ 1. Go black  ");
                    Console.WriteLine("     ^ 0. Exit  ");
                    Console.Write("     ^ => ");
                    int value = int.Parse(Console.ReadLine());
                    if (value == 1)
                    {
                        Face();
                    }
                    if (value == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("     ^ Thenk You !!!!! ");
                        start();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("     ^ Your Enter  Number Mistake Try Again ! ");
                        goto Mistake;
                    }

                }
                if (loans == 2)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("     ^ #. Loan  Price  6  month   18% !  ");
                    Console.WriteLine("     ^ #. Loan  Price  12 month  24% !  ");
                    Console.WriteLine("     ^ #. Loan  Price  18 month  30% !  ");
                    Console.WriteLine("     ^ #. Loan  Price  24 month  36% !  ");
                    Console.WriteLine("     ^ #. Loan  Price  36 month  45% !  ");
                Mistake:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("     ^ 1. Go black  ");
                    Console.WriteLine("     ^ 0. Exit  ");
                    Console.Write("     ^ => ");
                    int value = int.Parse(Console.ReadLine());
                    if (value == 1)
                    {
                        Face();
                    }
                    if (value == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("     ^ Thenk You !!!!! ");
                        start();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("     ^ Your Enter  Number Mistake Try Again ! ");
                        goto Mistake;
                    }
                }
                if (loans == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("     ^ Thenk You! ");
                    start();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("    ^ Eror number  Try again ! ");
                    Loanz();
                }

            }
        }
    }


}

