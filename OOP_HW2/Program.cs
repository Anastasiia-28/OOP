using OOP_HW2;
using System.Text;

Console.OutputEncoding = UTF8Encoding.UTF8;

Product product1 = new Product(23, 270, WholePartType.EURO);
product1.GetNewPrice(1, 1);
Product product2 = new Product(25, 27, WholePartType.HRYVNIA);
product2.GetNewPrice(24, 12);
Product product3 = new Product(29, 100, WholePartType.DOLLAR);
product3.GetNewPrice(1, 15);
Product product4 = new Product(23, 90, WholePartType.EURO);
product4.GetNewPrice(1, 150);
Product product5 = new Product(23, -90, WholePartType.EURO);
product5.GetNewPrice(1, 150);

Console.WriteLine("");

Violin violin = new Violin("Скрипка", "Струнний музичний смичковий інструмент.", "З'явився у середині XVI століття.");
violin.Show();
violin.Desc();
violin.History();
violin.Sound();
Cello cello = new Cello("Віолончель", "Струнний смичковий музичний інструмент, родини скрипкових, басо-тенорового регістру.", "Поява віолончелі відноситься до початку XVI століття.");
cello.Show();
cello.Desc();
cello.History();
cello.Sound();

Console.WriteLine("");

DecimalNumber decimalNumber = new DecimalNumber(1000);
Console.WriteLine(decimalNumber.ToBinary());
Console.WriteLine(decimalNumber.ToOctal());
Console.WriteLine(decimalNumber.ToHexadecimal());
DecimalNumber decimalNumber1 = new DecimalNumber(-119);
Console.WriteLine(decimalNumber1.ToBinary());
Console.WriteLine(decimalNumber1.ToOctal());
Console.WriteLine(decimalNumber1.ToHexadecimal());