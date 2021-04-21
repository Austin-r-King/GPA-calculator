using System;
using System.IO;

namespace GPAcalc
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string file = File.ReadAllText("/home/user/Projects/GPAcalc/major.gpa.txt");
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