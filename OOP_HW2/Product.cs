namespace OOP_HW2
{
    public class Product : Money
    {
        private long _wholePartOfPrice, _kopeckPartOfPrice;
        private long _wholePartOfNewPrice, _kopeckPartOfNewPrice;

        public Product(long wholePart, long kopeck, WholePartType wholePartType) : base(wholePart, kopeck, wholePartType)
        {
            (_kopeckPartOfPrice, _wholePartOfPrice) = СhangeACopecksCount(kopeck, wholePart);
        }

        public void GetNewPrice(long wholePartDiff, long kopeckPartDiff)
        {
            if (CheckOnNegativeValue(wholePartDiff, kopeckPartDiff) || CheckOnNegativeValue(_wholePartOfPrice, _kopeckPartOfPrice))
            {
                Console.WriteLine("Data must not be negative");
            }
            else
            {
                _wholePartOfNewPrice = _wholePartOfPrice - wholePartDiff;
                _kopeckPartOfNewPrice = _kopeckPartOfPrice - kopeckPartDiff;


                if (_kopeckPartOfNewPrice < 0)
                {
                    _wholePartOfNewPrice -= 1;
                    _kopeckPartOfNewPrice = 100 + _kopeckPartOfNewPrice;
                }

                ShowAmount(_wholePartOfNewPrice, _kopeckPartOfNewPrice);
            }
        }
    }
}
