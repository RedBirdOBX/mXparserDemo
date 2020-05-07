namespace mXParserDemo
{
    public class MathParserParams
    {
        public string Formula { get; set; }

        public int DecimalsToRoundAt { get; set; } = 2;


        public double SAValue { get; set; }
        public string SAExpression { get { return "SA"; } }

        public double SUValue { get; set; }
        public string SUExpression { get { return "SU"; } }

        public double COValue { get; set; }
        public string COExpression { get { return "CO"; } }

        public double TXValue { get; set; }
        public string TXExpression { get { return "TX"; } }

        public double RCVAL1Value { get; set; }
        public string RCVAL1Expression { get { return "RCVAL1"; } }

        public double ACVAL1Value { get; set; }
        public string ACVAL1Expression { get { return "ACVAL1"; } }

        public double ACVAL2Value { get; set; }
        public string ACVAL2Expression { get { return "ACVAL2"; } }

        public double TAX1RTValue { get; set; }
        public string TAX1RTExpression { get { return "TAX1RT"; } }
    }
}
