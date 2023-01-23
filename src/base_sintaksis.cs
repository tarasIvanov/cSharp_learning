//using System;
//using System.Linq;
//using System.Globalization;
//using Bogus;
//using System.Drawing;

//namespace ForAll
//{
//	class Simple_cod
//	{
//        static Random random = new Random();

//        public static void Main(string[] args)
//		{
//            //Faker faker = new Faker("uk");

//            //String name = faker.Name.LastName(Bogus.DataSets.Name.Gender.Female);

//            //Console.WriteLine(name);




//            //Задача на додавання елементу в масив
//            //int size = 5;
//            //int n = 2;
//            //int num = -20;

//            //int[] arr = new int[5] { 3, 7, -10, 3, -2 };

//            //int[] arr2 = new int[size + 1];

//            //for (int i = 0; i < n; i++)
//            //{
//            //	arr2[i] = arr[i];
//            //}

//            //for (int i = n + 1; i < size + 1; i++)
//            //{
//            //             arr2[i] = arr[i - 1];
//            //         }

//            //arr2[n] = num;

//            //for (int i = 0; i < size + 1; i++)
//            //{
//            //	Console.Write(arr2[i] + "\t");
//            //}



//            //Задача на видалення елементу з масиву
//            //int[] arr = { 5, 2, 6, 3 ,1, 10 ,12};

//            //         print(arr);

//            //int n = 6;


//            //int[] arr2 = new int[arr.Length-1];

//            //for (int i = 0; i < n; i++)
//            //{
//            //	arr2[i] = arr[i];
//            //}

//            //for (int i = n + 1; i <= arr2.Length; i++)
//            //{
//            //	arr2[i - 1] = arr[i];
//            //}


//            //print(arr2);


//            //Задача на дужки

//            //int counterO = 0;
//            //bool canOrNo = true;

//            //string str = "()faf(faf()()))";

//            //foreach (char el in str)
//            //{
//            //	if (counterO <= 0 && el == ')')
//            //	{
//            //                 canOrNo = false;
//            //                 break;
//            //	}

//            //	if (el == '(')
//            //	{
//            //		counterO++;
//            //	}

//            //	if (el == ')')
//            //	{
//            //		counterO--;
//            //	}
//            //}

//            //         if (counterO != 0 || canOrNo == false)
//            //         {
//            //             Console.WriteLine("Can't");
//            //         }
//            //         else
//            //         {
//            //             Console.WriteLine("Can");
//            //         }




//            //Трьохвимірний масив

//            //int[,,] arr = new int[3, 3, 5]
//            //{
//            //	{
//            //		{1, 2, 3, 4, 5 },
//            //                 {1, 2, 3, 4, 5 },
//            //		{1, 2, 3, 4, 5 }
//            //             },
//            //             {
//            //                 {1, 2, 3, 4, 5 },
//            //                 {1, 2, 3, 4, 5 },
//            //                 {1, 2, 3, 4, 5 }
//            //             },
//            //             {
//            //                 {1, 2, 3, 4, 5 },
//            //                 {1, 2, 3, 4, 5 },
//            //                 {1, 2, 3, 4, 5 }
//            //             }
//            //         };

//            //Random random = new Random();

//            ////for (int i = 0; i < arr.GetLength(0); i++)
//            ////{
//            ////	for (int j = 0; j < arr.GetLength(1); j++)
//            ////	{
//            ////		for (int k = 0; k < arr.GetLength(2); k++)
//            ////		{
//            ////			arr[i, j, k] = random.Next(10);
//            ////		}
//            ////	}
//            ////}

//            //         for (int i = 0; i < arr.GetLength(0); i++)
//            //         {
//            //             Console.WriteLine("Page № " + (i + 1));

//            //             for (int j = 0; j < arr.GetLength(1); j++)
//            //             {
//            //                 for (int k = 0; k < arr.GetLength(2); k++)
//            //                 {
//            //			Console.Write(arr[i, j, k] + " ");
//            //                 }
//            //		Console.WriteLine();
//            //             }
//            //	Console.WriteLine();
//            //         }





//            //Зубчаті масиви(масив масивів)

//            //         int[][] BigArr = new int[3][];

//            //for (int i = 0; i < BigArr.Length; i++)
//            //{
//            //             BigArr[i] = new int[random.Next(3, 5)];
//            //         }

//            //         for (int i = 0; i < BigArr.Length; i++)
//            //         {
//            //             for (int j = 0; j < BigArr[i].Length; j++)
//            //             {
//            //                 BigArr[i][j] = random.Next(10);
//            //             }
//            //         }

//            //         for (int i = 0; i < BigArr.Length; i++)
//            //         {
//            //             Console.WriteLine("arr № " + (i+1));

//            //             for (int j = 0; j < BigArr[i].Length; j++)
//            //             {
//            //                 Console.Write(BigArr[i][j] + " ");
//            //             }
//            //             Console.WriteLine("\n");
//            //         }





//            //Перезагрузка методів

//            //int[] arr1 = new int[5];

//            //arrayFilling(ref arr1);
//            //print(arr1);

//            //Console.WriteLine();

//            //int[,] arr2 = new int[5, 5];

//            //arrayFilling(ref arr2);
//            //print(arr2);


//            //Ігри з пам'яттю, ??, ??= 

//            //int[] arr1 = new int[2];

//            //arrayFilling(arr1);

//            //print(arr1);

//            //int[] arr = null;

//            //int[] res = arr ??= new int[0];

//            //Console.WriteLine("arr length = " + res.Length);
//            //Console.WriteLine("arr length = " + arr.Length);


//            //Змінити розмір масиву через метод Resize
//            //int[] arr = new int[5] { 10, 4, 5, 2, 6 };
//            //int[] arr = null;


//            //Resize(ref arr);

//            ////arrayFilling(arr);
//            //print(arr);


//            //in out params

//            //int a = 5;
//            //int b = 10;

//            //string str = "numb 1 = {0}\nnumb 2 = {1} {2}\n";

//            //Console.WriteLine(str, a, b, a);

//            //Console.WriteLine("sum 1 5 90 = " + Sum(1,5,90));



//            // Необов'язкові та іменованні параметри 

//            //Sum(5, 3, print:true);



//            //Рекурсія

//            //int[] arr = new int[5] {6, 100, 500, 2, 5 };

//            //recursoinArrPrint(arr);

//            //Console.WriteLine(recursionSumArr(arr));


//            //string str = "221";

//            //Console.WriteLine(recursionSumOfEllNum(str));



//            //Nullable
//            int? a = 4;
//            float b = 2.999999f;

//            int res = (int)(a + b);
//            Console.WriteLine(a + b);

//            int? t = null;

//            var random = new Random();

//            Console.WriteLine($"num a = {a} \t num b = {b}");




//        }

//        static int recursionSumOfEllNum(in string str, int FirstEll = 0)
//        {
//            //if (str.Length <= FirstEll)
//            //{
//            //    Console.WriteLine("sum = " + sum);
//            //    return;
//            //}

//            //sum += Convert.ToInt32(str[FirstEll]) - 48;

//            //recursionSumOfEllNum(str, sum, ++FirstEll);

//            if (str.Length <= FirstEll)
//                return 0;
            
//            int res = Convert.ToInt32(str[FirstEll]) - 48;

//            return res + recursionSumOfEllNum(str, ++FirstEll);
//        }

//        static int recursionSumArr(in int[] arr, int FirstEll = 0)
//        {
//            //if (arr.Length <= FirstEll)
//            //{
//            //    Console.WriteLine("sum = " + sum);
//            //    return;
//            //}

//            //sum += arr[FirstEll];
//            //FirstEll++;

//            //recursionSumArr(arr, FirstEll, sum);

//            if (arr.Length <= FirstEll)
//                return 0;
            

//            int res = arr[FirstEll];

//            return res + recursionSumArr(arr, ++FirstEll);
//        }

//        static void recursoinArrPrint(in int[] arr, int FirstEll = 0)
//        {
//            if (FirstEll == arr.Length)
//            {
//                return;
//            }

//            Console.WriteLine("arr [" + FirstEll + "] = " + arr[FirstEll]);

//            FirstEll++;

//            recursoinArrPrint(arr, FirstEll);
//        }


//        static int Sum(int a, int b, bool print = false)
//        {
//            int res = a + b;

//            if (print)
//            {
//                Console.WriteLine("a = " + a);
//                Console.WriteLine("b = " + b);
//                Console.WriteLine("sum = " + res);
//            }

//            return res;
//        }


//        static int Sum(bool print = false ,params int[] arr)
//        {
//            int sum = 0;

//            foreach (var item in arr)
//            {
//                sum += item;

//                if (print)
//                {
//                    Console.Write(item + " + ");
//                }
//            }

//            if (print)
//            {
//                Console.Write("= " + sum);
//            }

//            return sum;
//        }


//        /// <summary>
//        /// Копіює один масив в інший
//        /// </summary>
//        /// <typeparam name="T"></typeparam>
//        /// <param name="arr"></param>
//        /// <param name="arrForCopy"></param>
//        static void copyArr<T>(ref T[] arr, ref T[] arrForCopy)
//        {
//            arrForCopy = new T[arr?.Length ?? 0];

//            for (int i = 0; i < (arr?.Length ?? 0); i++)
//            {
//                arrForCopy[i] = arr[i];
//            }
//        }

//        /// <summary>
//        /// Міняє величину масиву
//        /// </summary>
//        /// <typeparam name="T"></typeparam>
//        /// <param name="arr"></param>
//        static void Resize<T>(ref T[] arr)
//        {
//            int size = arr?.Length ?? 0;

//            T[] arr2 = new T[size];

//            copyArr<T>(ref arr, ref arr2);

//            int newSize = size;
//            int num, edit = 0;
            

//            Console.WriteLine("print 1 if you want to make array bigger");
//            Console.WriteLine("print 2 if you want to make array smaller");
//            Console.WriteLine("print 3 if you want to make array with new size");
//            num = Convert.ToInt32(Console.ReadLine());

//            switch (num)
//            {
//                case 1: 
//                    Console.WriteLine("how many?");
//                    edit = Convert.ToInt32(Console.ReadLine());

//                    newSize += edit;
//                    break;

//                case 2:
//                    Console.WriteLine("how many?");
//                    do
//                    {
//                        edit = Convert.ToInt32(Console.ReadLine());

//                        if (edit >= size)
//                        {
//                            Console.WriteLine("edit need to be smaller than size of array ");
                            
//                        }

//                    } while (edit >= size);

//                    newSize -= edit;
//                    break;

//                case 3:
//                    Console.WriteLine("enter new size");
//                    edit = Convert.ToInt32(Console.ReadLine());

//                    newSize = edit;
//                    break;


//                default:
//                    Console.WriteLine("enter 1-2-3");
//                    return;
//            }

//            arr = new T[newSize];

//            if (newSize >= size)
//            {
//                for (int i = 0; i < arr2.Length; i++)
//                {
//                    arr[i] = arr2[i];
//                }
//            }
//            else if (newSize < size)
//            {
//                for (int i = 0; i < arr.Length; i++)
//                {
//                    arr[i] = arr2[i];
//                }
//            }
//        }

//        static void arrayFilling(int[] arr)
//		{
//			for (int i = 0; i < arr.Length; i++)
//			{
//				arr[i] = random.Next(10);
//			}
//        }

//        static void arrayFilling(ref int[,] arr)
//        {
//            for (int i = 0; i < arr.GetLength(0); i++)
//            {
//                for (int j = 0; j < arr.GetLength(1); j++)
//                {
//                    arr[i, j] = random.Next(10);
//                }
//            }
//        }

//        public static void print(in int[] arr)
//        {
//            for (int i = 0; i < arr.Length; i++)
//            {
//                Console.Write(arr[i] + "\t");
//            }
//            Console.WriteLine();
//        }

//        public static void print(in int[,] arr)
//        {
//            for (int i = 0; i < arr.GetLength(0); i++)
//            {
//                for (int j = 0; j < arr.GetLength(1); j++)
//                {
//                    Console.Write(arr[i, j] + "\t");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}

