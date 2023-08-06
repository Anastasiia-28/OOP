namespace OOP_HW2
{
    public class Money
    {
        protected long _wholePart;
        protected long _kopeck;

        protected long _heapedCountOfKopecks;

        protected WholePartType _wholePartType;
        protected CopeckPartType _kopeckPartType;

        public Money(long wholePart, long kopeck, WholePartType wholePartType)
        {
            _wholePartType = wholePartType;
            _kopeckPartType = GetCopeckType(_wholePartType);
            (_kopeck, _wholePart) = СhangeACopecksCount(kopeck, wholePart);

        }

        protected bool CheckOnNegativeValue(long value1, long value2)
        {
            if (value1 < 0 || value2 < 0)
                return true;
            else
                return false;
        }

        protected CopeckPartType GetCopeckType(WholePartType wholePartType)
        {
            switch (wholePartType)
            {
                case WholePartType.DOLLAR:
                    return CopeckPartType.CENT;

                case WholePartType.EURO:
                    return CopeckPartType.EURO_CENT;

                case WholePartType.HRYVNIA:
                    return CopeckPartType.KOPECK;

                default:
                    return CopeckPartType.NONE;
            }
        }

        protected void ShowAmount(long wholePart, long kopeckPart)
        {
            string outputStr = $"{wholePart} {_wholePartType}, {kopeckPart} {_kopeckPartType}";

            if (wholePart > 1)
                outputStr = $"{wholePart} {_wholePartType}S, {kopeckPart} {_kopeckPartType}";

            if (kopeckPart > 1)
                outputStr += "S";

            Console.WriteLine($"Result: {outputStr}");

        }

        protected (bool, long) CheckKopeckCount(long kopeck)
        {
            if (kopeck < 100)
                return (false, kopeck);

            _heapedCountOfKopecks = kopeck / 100;
            kopeck %= 100;

            return (true, kopeck);
        }

        protected (long, long) СhangeACopecksCount(long kopeck, long wholePart)
        {
            long kopeckResult = kopeck;
            long wholePartResult = wholePart;
            (bool isFull, long kopeckFromCheck) = CheckKopeckCount(kopeck);

            if (isFull)
            {
                wholePartResult += _heapedCountOfKopecks;
                kopeckResult = kopeckFromCheck;
            }
            return (kopeckResult, wholePartResult);
        }
    }
}
public enum WholePartType
{
    NONE,
    DOLLAR,
    EURO,
    HRYVNIA
}

public enum CopeckPartType
{
    NONE,
    CENT,
    EURO_CENT,
    KOPECK
}