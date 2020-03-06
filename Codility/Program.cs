using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    class Program
    {
        static void Main(string[] args)
        {
            int teste1 = Teste1();
            int teste2 = Teste2();
            string teste3 = Teste3();

            string teste4 = Teste4();

            Console.WriteLine(teste1);
            Console.WriteLine(teste2);
            Console.WriteLine(teste3);
            Console.WriteLine(teste4);
            Console.ReadKey();

        }

        static int Teste1()
        {
            int[] A = new int[] { 1, 3, 6, 4, 1, 2 }; // RESULTADO = 5
            //int[] A = new int[] { 1, 2, 3 }; // RESULTADO = 4
            //int[] A = new int[] { -1, -3 }; // RESULTADO = 1

            Array.Sort(A);
            int number = 0;
            int biggerInArray = 0;

            if (A[A.Length - 1] <= 0)
                biggerInArray = 1;
            else
                biggerInArray = A[A.Length - 1] + 1;

            for (int i = biggerInArray; i > 0; i--)
            {
                if (Array.IndexOf(A, i) == -1)
                {
                    number = i;
                }
            }

            return number;
        }

        static int Teste2()
        {
            int[] A = new int[] { 2, 2, 1, 0, 1 };
            int biggerInArray = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > biggerInArray)
                {
                    biggerInArray = A[i];
                }

            }

            int smallerNumber = biggerInArray;
            int smallerNumberPosition = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < smallerNumber)
                {
                    smallerNumber = A[i];
                    smallerNumberPosition = i;
                }

            }

            return smallerNumberPosition;
        }

        static string Teste3()
        {
            string S = "uuuuxaaaaxuuu";

            int counter = 0;
            string previousChar = string.Empty;
            string finalString = string.Empty;
            for (int i = 0; i < S.Length; i++)
            {
                if (i == 0)
                {
                    previousChar = S[i].ToString();
                    finalString = finalString + previousChar;
                    counter = counter + 1;
                }
                else
                {
                    if (S[i].ToString() == previousChar)
                    {
                        counter = counter + 1;
                        if (counter < 3)
                        {
                            finalString = finalString + previousChar;
                        }
                    }
                    else
                    {
                        counter = 1;
                        previousChar = S[i].ToString();
                        finalString = finalString + previousChar;
                    }
                }
            }

            return finalString;
        }

        static string Teste4()
        {
            int U = 3;
            int L = 2;
            int[] C = new int[] { 2,1,1,0,1 };

            int[] value1 = new int[C.Length];
            int[] value2 = new int[C.Length];
            int sumValue1 = 0;
            int sumValue2 = 0;
            string final = string.Empty;

            for (int i = 0; i < C.Length; i++)
            {
                if (C[i] == 0)
                {
                    value1[i] = 0;
                    value2[i] = 0;
                }
                else if (C[i] == 1)
                {
                    if (sumValue1 < U)
                    {
                        value1[i] = 1;
                        value2[i] = 0;
                        sumValue1 = sumValue1 + 1;
                    }
                    else
                    {
                        if (sumValue2 < L)
                        {
                            value1[i] = 0;
                            value2[i] = 1;
                            sumValue2 = sumValue2 + 1;
                        }
                    }
                }
                else if (C[i] == 2)
                {
                    value1[i] = 1;
                    value2[i] = 1;
                    sumValue1 = sumValue1 + 1;
                    sumValue2 = sumValue2 + 1;
                }
            }

            if (sumValue1 == U && sumValue2 == L)
            {

                if (string.IsNullOrEmpty(final))
                {
                    string str1 = string.Empty;
                    string str2 = string.Empty;
                    foreach (int i in value1)
                    {
                        str1 = str1 + i.ToString();
                    }

                    foreach (int i in value2)
                    {
                        str2 = str2 + i.ToString();
                    }

                    final = str1 + "," + str2;

                }
            }
            else
            {
                final = "IMPOSSIBLE";
            }

            return final;
        }
    }
}
