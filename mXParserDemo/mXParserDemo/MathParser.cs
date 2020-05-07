using org.mariuszgromada.math.mxparser;
using System.Collections.Generic;

namespace mXParserDemo
{
    public static class MathParser
    {
        public static decimal ExecuteFormula(MathParserParams mathParserParams)
        {
            decimal results = 0;

            // build list of all possible args and send it in. It will only use that the formula requires.
            List<Argument> arguments = new List<Argument>();

            Argument saVal = new Argument(mathParserParams.SAExpression, mathParserParams.SAValue);
            arguments.Add(saVal);

            Argument suVal = new Argument(mathParserParams.SUExpression, mathParserParams.SUValue);
            arguments.Add(suVal);

            Argument co = new Argument(mathParserParams.COExpression, mathParserParams.COValue);
            arguments.Add(co);

            Argument txVal = new Argument(mathParserParams.TXExpression, mathParserParams.TXValue);
            arguments.Add(txVal);

            Argument rcVal1 = new Argument(mathParserParams.RCVAL1Expression, mathParserParams.RCVAL1Value);
            arguments.Add(rcVal1);

            Argument acVal1 = new Argument(mathParserParams.ACVAL1Expression, mathParserParams.ACVAL1Value);
            arguments.Add(acVal1);

            Argument acVal2 = new Argument(mathParserParams.ACVAL2Expression, mathParserParams.ACVAL2Value);
            arguments.Add(acVal2);

            Argument tx1Rt = new Argument(mathParserParams.TAX1RTExpression, mathParserParams.TAX1RTValue);
            arguments.Add(tx1Rt);



            Expression exp = new Expression(mathParserParams.Formula);
            exp.addArguments(arguments.ToArray());

            // consider logging the formula...such as exp.getExpressionString();

            var expResults = exp.calculate();

            // consider logging the results ...such as expResults.ToString();

            if (expResults.ToString() == "NaN")
            {
                return results;
            }

            results = (decimal)exp.calculate();
            results = decimal.Round(results, mathParserParams.DecimalsToRoundAt);
            return results;
        }
    }
}
