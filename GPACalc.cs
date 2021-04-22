using System;
using System.IO;

namespace GPAcalc
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("To connect your file, find your file location in your file manager.");
            Console.WriteLine("Right click the file and click on properties.");
            Console.WriteLine("Then triple click parent folder, or file location");
            Console.WriteLine("Next right click again and click copy.");
            Console.WriteLine("Now open this tab back up and press shift + ctrl + v");
            Console.WriteLine("Then open back up the file and right click it.");
            Console.WriteLine("Click on properties again, and then right click and select copy the name.");
            Console.WriteLine("Open this tab again, and click the forward slash / ");
            Console.WriteLine("and then press shift + ctrl + v.");
            Console.WriteLine("Finally press enter.");
            string UserInput = Console.ReadLine();
            string file = File.ReadAllText(UserInput);
            string[] gardes = file.Split( '\n' );
            double totalGPA = 0;
            double AmountOfClasses = 0;
            foreach (var grade in gardes)
            {
                string[] split = grade.Split(' ');
                AmountOfClasses++;

                if (split[0] == "H")
                {
                    if (split[1] == "A")
                    {
                        totalGPA = totalGPA + 4.5;
                    }
                    else if (split[1] == "B")
                    {
                        totalGPA = totalGPA + 3.5;
                    }
                    else if (split[1] == "C")
                    {
                        totalGPA = totalGPA + 2.5;
                    }
                    else if (split[1] == "D")
                    {
                        totalGPA = totalGPA + 1.5;
                    }
                    else if (split[1] == "F")
                    {
                        totalGPA = totalGPA + 0.0;
                    }
                }
                else if (split[0] == "AP")
                {
                    if (split[1] == "A")
                    {
                        totalGPA = totalGPA + 5;
                    }
                    else if (split[1] == "B")
                    {
                        totalGPA = totalGPA + 4;
                    }
                    else if (split[1] == "C")
                    {
                        totalGPA = totalGPA + 3;
                    }
                    else if (split[1] == "D")
                    {
                        totalGPA = totalGPA + 2;
                    }
                    else if (split[1] == "F")
                    {
                        totalGPA = totalGPA + 0.0;
                    }
                }
                else if (split[0] == "AP+")
                {
                    if (split[1] == "A")
                    {
                        totalGPA = totalGPA + 5.5;
                    }
                    else if (split[1] == "B")
                    {
                        totalGPA = totalGPA + 4.4;
                    }
                    else if (split[1] == "C")
                    {
                        totalGPA = totalGPA + 3.5;
                    }
                    else if (split[1] == "D")
                    {
                        totalGPA = totalGPA + 2.5;
                    }
                    else if (split[1] == "F")
                    {
                        totalGPA = totalGPA + 0.0;
                    }
                }
                else if(split[0] == "CP")
                {
                    if (split[1] == "A")
                    {
                        totalGPA = totalGPA + 4.0;
                    }
                    else if (split[1] == "B")
                    {
                        totalGPA = totalGPA + 3.0;
                    }
                    else if (split[1] == "C")
                    {
                        totalGPA = totalGPA + 2.0;
                    }
                    else if (split[1] == "D")
                    {
                        totalGPA = totalGPA + 1.0;
                    }
                    else if (split[1] == "F")
                    {
                        totalGPA = totalGPA + 0.0;
                    }
                }
                else if (split[0] == "F")
                {
                    if (split[1] == "A")
                    {
                        totalGPA = totalGPA + 4.0;
                    }
                    else if (split[1] == "B")
                    {
                        totalGPA = totalGPA + 3.0;
                    }
                    else if (split[1] == "C")
                    {
                        totalGPA = totalGPA + 2.0;
                    }
                    else if (split[1] == "D")
                    {
                        totalGPA = totalGPA + 1.0;
                    }
                    else if (split[1] == "F")
                    {
                        totalGPA = totalGPA + 0.0;
                    }
                }
            }

            AmountOfClasses= AmountOfClasses-1;
 

            double FinalGPAd = totalGPA / AmountOfClasses;
            string FinalGrade = Convert.ToString(FinalGPAd);
            if (FinalGrade.Length > 4)
            {
                if (FinalGrade.Length>4)
                {
                    string item1 = Convert.ToString(FinalGrade[0]);
                    string item2 = Convert.ToString(FinalGrade[1]);
                    string item3 = Convert.ToString(FinalGrade[2]);
                    string item4 = Convert.ToString(FinalGrade[3]);
                    string item5 = Convert.ToString(FinalGrade[4]);
                    Console.WriteLine(item1 + item2 + item3 + item4 + item5);

                }
                else
                {
                    string item1 = Convert.ToString(FinalGrade[0]);
                    string item2 = Convert.ToString(FinalGrade[1]);
                    string item3 = Convert.ToString(FinalGrade[2]);
                    string item4 = Convert.ToString(FinalGrade[3]);
                    string FinalGradenum = item1 + item2 + item3 + item4;
                    Console.WriteLine(FinalGradenum);
                }
            }
            else
            {
                Console.WriteLine(FinalGrade);
            }

        }
    }
}