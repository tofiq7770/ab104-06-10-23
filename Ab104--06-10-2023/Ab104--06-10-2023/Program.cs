
//using System;

//namespace Program
//{
//    class Program
//    {


//        static void Main()
//        {
//            int[] myArray = { 1, 2, 3, 4, 5 };

//            int[] valuesToAdd = { 6, 7, 8 };

//            InsertArray(myArray, valuesToAdd);

//            foreach (int item in myArray)
//            {
//                Console.Write(item + " ");
//            }
//        }

//        static void InsertArray(int[] array, params int[] values)
//        {
//            int newArrayLength = array.Length + values.Length;
//            int[] newArray = new int[newArrayLength];

//            for (int i = 0; i < array.Length; i++)
//            {
//                newArray[i] = array[i];
//            }
//            for (int i = 0; i < values.Length; i++)
//            {
//                newArray[array.Length + i] = values[i];
//            }
//            for (int i = 0; i < newArray.Length; i++)
//            {
//                array[i] = newArray[i];
//            }
//        }
//    }
//}



Main();

 static void Main()
{
    int miqdar = 2034, deposit, cixan;
    int choice, pin = 0, x = 0;
    Console.WriteLine("Pin daxil edin ");
    pin = int.Parse(Console.ReadLine());
    while (true)
    {
        Console.WriteLine("ATM \n");
        Console.WriteLine("***************");

        Console.WriteLine("1. Balansi goster\n");
        Console.WriteLine("2. Pul cixar \n");
        Console.WriteLine("3. Pul daxil et \n");
        Console.WriteLine("4. Cix \n");
        choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("\n Sizin Balans: {0}", miqdar);
                break;
            case 2:
                Console.WriteLine("\n Cixarilacaq pul miqdari ");
                cixan = int.Parse(Console.ReadLine());
                if (cixan % 100 != 0)
                {
                    Console.WriteLine("\n 100 den boyuk miqdar yazin");
                }
                else if (cixan > (miqdar - 1000))
                {
                    Console.WriteLine("\n Yetersiz Pul miqdari ");
                }
                else
                {
                    miqdar = miqdar - cixan;
                    Console.WriteLine("\n\n Pulunuzu goturu");
                    Console.WriteLine("\n Sizin Balans : {0}", miqdar);
                }
                break;
            case 3:
                Console.WriteLine("\n Daxil edilecek pulu daxil et");
                deposit = int.Parse(Console.ReadLine());
                miqdar = miqdar + deposit;
                Console.WriteLine("Sizin Pul daxil edildi ");
                Console.WriteLine("Sizin Toplam Balans : {0}", miqdar);
                break;
            case 4:
                Console.WriteLine("\n THANK YOU…");  
                        break;
        }
    }
    Console.WriteLine("\n\n Atmden istifadeniz ucun sagolun");
}