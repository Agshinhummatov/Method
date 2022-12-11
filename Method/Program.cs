
//1) Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.

//var result = IsDivideOrNote(42);

//Console.WriteLine(result);
//static bool IsDivideOrNote(int n)
//{
//    if (n % 21 == 0)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}



//2) n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.




//Console.WriteLine(sum(20, 40));
//static int sum(int n, int m)
//{
//    int sum = 0;
//    if (n % 2 == 0 && m % 2 == 0)
//    {
//        sum = n + m;
//    }
//    return sum;
//}



//3) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin



//Sum(10, 14);
//static void Sum(int n, int m)
//{
//    int sum = 0;
//    for (int i = n; i < m; i++)
//    {
//        if (i % 2 == 1)
//        {
//            sum = sum + i;
//        }
//    }
//    Console.WriteLine(sum);
//}



//4) Verilmish arrayin icindeki tek ededlerin cemini tapin.


//int[] arr = { 7, 9, 11, 17, 24, 31 };
//Sum(arr);

//static void Sum(int[] arr)
//{
//    int sum = 0;
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] % 2 == 1)
//        {
//            sum = sum + arr[i];
//        }
//    }
//    Console.WriteLine(sum);
//}


//5) Verilmish arrayin icindeki cut ededlerin sayini tapin.


//int[] arr = { 7, 10, 15, 20, 25, 31, 42 };
//Count(arr);

//static void Count(int[] arr)
//{
//    int count = 0;
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] % 2 == 0)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);
//}


////6) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.
///


//Count(12, 20);
//static void Count(int n, int m)
//{
//	int count = 0;
//	for (int i = n; i < m; i++)
//	{
//		if (i % 2 == 1)
//			count++;
//	}
//	Console.WriteLine(count);
//}

//7) Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin cemini tapin.

//Sum(13, 17);
//static void Sum(int n, int m)
//{
//    int sum = 0;
//    for (int i = n; i < m; i++)
//    {
//        if (i % 2 == 0)
//        {
//            sum = sum + i;
//        }
//    }
//    Console.WriteLine(sum);
//}



//8) Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin sayini tapin.

//Count(15, 19);
//static void Count(int n, int m)
//{
//    int count = 0;
//    for (int i = n; i < m; i++)
//    {
//        if (i % 2 == 0)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);
//}



//9) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.



//Count(6);
//static void Count(int n)
//{
//    int count = 0;
//    if (n <= 0)
//    {
//        Console.WriteLine("Duzgun eded daxil edin");
//    }
//    else if (n == 1)
//    {
//        Console.WriteLine(" Ne sadedir nedeki murekkeb");
//    }
//    else
//    {
//        for (int i = 1; i <= n; i++)
//        {
//            if (n % i == 0)
//            {
//                count++;
//            }
//        }
//        if (count > 2)
//        {
//            Console.WriteLine("Murekkeb");
//        }
//        else
//        {
//            Console.WriteLine("Sade");
//        }
//    }
//}



//10)n ededinin faktorialini hesablamaq.

//Faktorial(3);
//static void Faktorial(int n)
//{
//	int multipe = 1;
//	for (int i = 1; i <= n; i++)
//	{
//		multipe *= i;
//	}
//	Console.WriteLine(multipe);
//}
