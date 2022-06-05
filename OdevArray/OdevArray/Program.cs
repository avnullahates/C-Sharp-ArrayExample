using System;

namespace OdevArray
{
    class Program
    {
        static void Main(string[] args)
        {

            //DIZILER (ARRAYS)

            //Dizi Kavrami: Ayni turden olan nesneler kumesine dizi(array) denir. Dizilerdeki elemanlarin isimleri ortaktir. Ayirt edici ozellikleri bellekteki yerleridir.
            //// Concept of Array: A set of objects of the same type is called an array. Elements in arrays have common names. Their distinguishing features are their memory location.

            //Dizi Tanimlama:
            //int[] array = new int[25];

            //int[] array2;
            //array2 = new int[20];

            //Dizi Ornek 1: Klavyeden kullanici tarafindan girilen 6 sayidan en buyugunu bulan program dizi kullananrak yaziniz.
            //Array Example 1: The program that finds the largest of the 6 numbers entered by the user from the keyboard, write using array.

            int[] numbers = new int[6];

            for (int i = 0; i < 6; i++)
            {
                Console.Write((i + 1) + ". sayiyi giriniz: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int biggest = numbers[0];
            for (int i = 0; i < 6; i++)
            {
                if (numbers[i] > biggest)
                {
                    biggest = numbers[i];
                }
            }
            Console.WriteLine("The biggest number: " + biggest);







            //Dizi Ornek 2: Kullanici tarafindan girilen 5 sayinin kucukten buyuge dogru siralayan programi yaziniz. 
            //Array Example 2: Write a program that sorts the 5 numbers entered by the user from smallest to largest.

            int d;
            int[] numbers2 = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write((i + 1) + ". sayiyi giriniz: ");
                numbers2[i] = int.Parse(Console.ReadLine());

            }

            //Array.Sort(numbers2);
            //Array.Reverse(numbers2);


            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (numbers2[i] < numbers2[j])
                    {
                        d = numbers2[i];
                        numbers2[i] = numbers2[j];
                        numbers2[j] = d;
                    }
                }
            }

            foreach (int num in numbers2)
            {
                Console.WriteLine(num);
            }








            // Dizi Örnek 3:  Klavyeden kullanıcı tarafından girilen 5 ismi alfabetik olarak sıralayan programı dizi kullanarak yazınız.
            //Array Example 3: Write a program that alphabetically lists 5 names entered by the user on the keyboard, using a string.

            string[] names = new string[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter " + (i+1) + ". name: ");
            names[i] = Console.ReadLine();
        }
        Console.WriteLine();            

        Console.WriteLine("List before sorting: ");
        int count = 1;
        foreach (string name in names)
        {
            Console.WriteLine(count+". name: "+name);
            count++;
        }
        Console.WriteLine();
        Array.Sort(names);
        Console.WriteLine("List after sorting: ");
        count = 1;
        foreach (string name in names)
        {
            Console.WriteLine(count + ". name: " + name);
            count++;
        }

        








        // Dizi Örnek 4: Klavyeden kullanıcı tarafından girilen, beş elemanlı bir sayı dizisinde, son rakamı 0(sıfır) olan sayıların sayısını bulan programı yazınız.
        //Array Example 4: Write a program that finds the number of numbers whose last digit is 0 (zero) in a five-element array of numbers entered by the user from the keyboard.
        
        string[] numberss = new string[5];
        int count2 = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter {i+1}. number: ");
            numberss[i] = Console.ReadLine();     

            bool endWith = numberss[i].EndsWith("0");

            if (endWith)                
                count2++;

        }
        Console.WriteLine($"There are {count2} numbers whose last digit is 0 (zero).");

        










        // Dizi Örnek 5: 10 elemanlı bir dizinin elemanları 1-1000 arasında bilgisayar tarafından rastgele atanacaktır. Bu dizideki 500-600 arasındaki sayıların toplamı ile 100-500 arasındaki sayıların sayısını bulan programı yazınız.
        //Array Example 5: Elements of a 10-element array will be randomly assigned by the computer between 1-1000. Write a program to find the sum of the numbers between 500-600 and the number of numbers between 100-500 in this array.

        
        Random rnd = new Random();
        int count3 = 0;
        int sum = 0;
        int[] number3 = new int[10];
        for (int i = 0; i < 10; i++)
        {
            number3[i] = rnd.Next(1, 1001);
            if (number3[i] > 500 && number3[i] < 600)
            {
                sum += number3[i];
            }
            if (number3[i] > 100 && number3[i] < 500)
            {
                count3++;
            }

        }
        Console.WriteLine();


        int count4 = 1;
        foreach (int item in number3)
        {
            Console.WriteLine(count4 + ". Number: " + item);
            count4++;
        }
        Console.WriteLine();

        Console.WriteLine("Sum of the numbers between 500-600: "  + sum);
        Console.WriteLine("Number of numbers between 100-500: " + count3);
        


        // Dizi Örnek 6: Sayısal loto programı yazınız. (Kullanıcının oynamak istediği kolon sayısına göre, otomatik rastgele sayı atama gibi düşünebilirsiniz. Sayısal Loto makinelerinin otomatik numara doldurması gibi. En az 1 en fazla 8 kolon oynanabilir.)


        start: Console.WriteLine("Oynamak istediginiz kolon sayisini giriniz: (1-8)");
            int kolon = Convert.ToInt32(Console.ReadLine());
            if (kolon < 1 || kolon > 8)
            {
                goto start;
            }

            int[] loto = new int[kolon];

            Random rnd1 = new Random();
            int count5 = 0;
            for (int i = 0; i < kolon; i++)
            {
                loto[i] = rnd1.Next(1, 91);
                //Console.WriteLine("The number: " + loto[i]);

                Console.Write($"Enter {i + 1}. number: ");
                int userLoto = int.Parse(Console.ReadLine());

                if (loto[i] == userLoto)
                {
                    count5++;
                }
            }

            if (count5 == kolon)
            {
                Console.WriteLine("Congratulations! You won the biggest award");
            }
            else if (count5 > 0)
            {
                Console.WriteLine($"You matched {count5} numbers. ");
            }
            else
            {
                Console.WriteLine("Sorry. You did not won any award :(");
            }


            Console.ReadLine();




        }
    }
}
