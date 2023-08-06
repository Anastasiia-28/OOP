namespace OOP_HW2
{
    public struct DecimalNumber
    {
        private int decimalNumber;

        public DecimalNumber(int number)
        {
            decimalNumber = number;
        }

        private string ToBinaryOrOctal(int baseNumber)
        {
            if (decimalNumber <= 0)
                return ConvertNegativeOrNullNumber(baseNumber);

            int number = decimalNumber;

            string resultNumber = string.Empty;

            while (number > 0)
            {
                resultNumber = (number % baseNumber) + resultNumber;
                number /= baseNumber;
            }

            return resultNumber;
        }

        public string ToBinary()
        {
            int baseNumber = 2;

            return ToBinaryOrOctal(baseNumber);
        }

        public string ToOctal()
        {
            int baseNumber = 8;

            return ToBinaryOrOctal(baseNumber);
        }

        public string ToHexadecimal()
        {
            int baseNumber = 16;

            if (decimalNumber <= 0)
                return ConvertNegativeOrNullNumber(baseNumber);

            int number = decimalNumber;
            string result = "";
            string set = "0123456789ABCDEF";

            while (number > 0)
            {
                result += set[number % 16];
                number /= 16;
            }

            return new string(result.Reverse().ToArray());
        }

        private string ConvertNegativeOrNullNumber(int baseNumber)
        {
            string resultNumber = Convert.ToString(decimalNumber, baseNumber);

            return resultNumber.ToUpper();
        }
    }
}
