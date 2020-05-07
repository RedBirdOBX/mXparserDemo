using System;
using System.Collections.Generic;

namespace mXParserDemo
{
    public static class Calculator
    {
        public static List<string> TestFormulas
        {
            // completely pointless formulas...this just prove it "does math".
            get
            {
                return new List<string>
                {
                    "((SA+SU-CO+TX)* ACVAL2)*(RCVAL1*1.2)",
                    "(((SA+SU-CO)* ACVAL1)/2)-(((SA+SU-CO)* ACVAL1)/2)/(1+TAX1RT)",
                    "(((SA+SU-CO)* ACVAL1)/2)/(1+TAX1RT)",
                    "(((SA+SU-CO)* ACVAL1)/3)-(((SA+SU-CO)* ACVAL1)/3)/(1+TAX1RT)",
                    "(((SA+SU-CO)* ACVAL1)/3)/(1+TAX1RT)",
                };
            }
        }

        public static void ExecuteDemo()
        {
            decimal results = 0;

            foreach (string forumla in TestFormulas)
            {
                Console.WriteLine($"Calculating {forumla}");

                MathParserParams mathParserParams = new MathParserParams()
                {
                    DecimalsToRoundAt = 2,
                    Formula = forumla,
                    SAValue = GetRandomNumber(),
                    SUValue = GetRandomNumber(),
                    COValue = GetRandomNumber(),
                    TXValue = GetRandomNumber(),
                    RCVAL1Value = GetRandomNumber(),
                    ACVAL1Value = GetRandomNumber(),
                    ACVAL2Value = GetRandomNumber(),
                    TAX1RTValue = GetRandomNumber()
                };

                results = MathParser.ExecuteFormula(mathParserParams);
                Console.WriteLine($"Results: {results}");

                Console.WriteLine("");
            }

            Console.WriteLine("....all done.....");
            Console.ReadLine();
        }


        private static double GetRandomNumber()
        {
            Random rnd = new Random();
            return (rnd.Next(1, 100));
        }
    }
}
