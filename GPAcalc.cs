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
            double FinalGrade = 0;
            int AmountOfClasses = 0;
            foreach (var grade in gardes)
            {
                string[] split = grade.Split(' ');
                AmountOfClasses++;
                if (split[0] == "Honors")
                {
                    if (split[1] == "A")
                    {
                        FinalGrade = FinalGrade + 4.5;
                    }
                    else if (split[1] == "B")
                    {
                        FinalGrade = FinalGrade + 3.5;
                    }
                    else if (split[1] == "C")
                    {
                        FinalGrade = FinalGrade + 2.5;
                    }
                    else if (split[1] == "D")
                    {
                        FinalGrade = FinalGrade + 1.5;
                    }
                    else if (split[1] == "F")
                    {
                        FinalGrade = FinalGrade + 0.0;
                    }
                }
                else if (split[0] == "AP")
                {
                    if (split[1] == "A")
                    {
                        FinalGrade = FinalGrade + 5;
                    }
                    else if (split[1] == "B")
                    {
                        FinalGrade = FinalGrade + 4;
                    }
                    else if (split[1] == "C")
                    {
                        FinalGrade = FinalGrade + 3;
                    }
                    else if (split[1] == "D")
                    {
                        FinalGrade = FinalGrade + 2;
                    }
                    else if (split[1] == "F")
                    {
                        FinalGrade = FinalGrade + 0.0;
                    }
                }
                else if (split[0] == "AP+")
                {
                    if (split[1] == "A")
                    {
                        FinalGrade = FinalGrade + 5.5;
                    }
                    else if (split[1] == "B")
                    {
                        FinalGrade = FinalGrade + 4.4;
                    }
                    else if (split[1] == "C")
                    {
                        FinalGrade = FinalGrade + 3.5;
                    }
                    else if (split[1] == "D")
                    {
                        FinalGrade = FinalGrade + 2.5;
                    }
                    else if (split[1] == "F")
                    {
                        FinalGrade = FinalGrade + 0.0;
                    }
                }
                else if(split[0] == "CP")
                {
                    if (split[1] == "A")
                    {
                        FinalGrade = FinalGrade + 4.0;
                    }
                    else if (split[1] == "B")
                    {
                        FinalGrade = FinalGrade + 3.0;
                    }
                    else if (split[1] == "C")
                    {
                        FinalGrade = FinalGrade + 2.0;
                    }
                    else if (split[1] == "D")
                    {
                        FinalGrade = FinalGrade + 1.0;
                    }
                    else if (split[1] == "F")
                    {
                        FinalGrade = FinalGrade + 0.0;
                    }
                }
                else if (split[0] == "F")
                {
                    if (split[1] == "A")
                    {
                        FinalGrade = FinalGrade + 4.0;
                    }
                    else if (split[1] == "B")
                    {
                        FinalGrade = FinalGrade + 3.0;
                    }
                    else if (split[1] == "C")
                    {
                        FinalGrade = FinalGrade + 2.0;
                    }
                    else if (split[1] == "D")
                    {
                        FinalGrade = FinalGrade + 1.0;
                    }
                    else if (split[1] == "F")
                    {
                        FinalGrade = FinalGrade + 0.0;
                    }
                }
            }
            Console.WriteLine(FinalGrade / AmountOfClasses);
        }
    }
}
//foreach (var i in split)
//{
//Console.WriteLine(i);
//}

