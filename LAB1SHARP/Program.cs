class lab1
{
    /*
Ввести с консоли массив целых чисел (массив вводится в виде строки, содержащей элементы, разделенные пробелами) и отсортировать его методом прямого выбора. 
Реализовать вывод результатов сортировки на каждой итерации. Вывести для каждого уникального элемента массива процент от общего количества элементов.
     */
    public static void lab11()
    {
        int min, temp;
        int[] arr = new int[5];
        Console.Write("Введите масив");
        string s = Console.ReadLine();      //cчитал строку
        char[] str = s.ToCharArray();       //передал значения в массив чар
        for (int i = 0; i < 5;)             //передал значения в массив инт
        {
            for (int j = 0; j < 10; j++)
                if (j % 2 != 1)
                {
                    arr[i] = s[j] - '0';
                    i++;
                }
        }
        //сортировка
        for (int i = 0; i < arr.Length - 1; i++)
        {
            min = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[min])
                    min = j;
            }
            if (min != i)
            {
                temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
            Console.Write("\nИтерация" + i + " ");
            for (int k = 0; k < 5; k++)
            {
                Console.Write(" " + arr[k] + " ");
            }
        }
        //массив вывода
        Console.Write("\n");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(arr[i] + " ");
        }
        //посчитал и вывел кол-во уникальных элементов и их уникальность
        int n = 1;
        for (int i = 0; i < 4; i++)
        {
            if (arr[i] != arr[i + 1])
                n++;
        }
        if (n > 5)
            n--;
        Console.Write("\nколичество униальных элементов" + n);

        int x = 1;
        for (int i = 0; i < 4; i++)
            if (arr[i] == arr[i + 1])
                x++;
            else
            {
                Console.Write("\nу цифры " + arr[i] + " уникальность " + x * 100 / 5 + "%");
                x = 1;
            }
        if (arr[3] != arr[4])
            Console.Write("\nу цифры " + arr[4] + " уникальность " + 100 / 5 + "%");
        if (x == 5)
            Console.Write("\nу цифры " + arr[0] + " уникальность " + 100 + "%");

    }

    /*
вести двухмерный массив целых чисел. Определить есть ли в массиве структура следующего вида (X – число):
-	X	-
X	X	X
-	X	-
Например
1	2	3
2	2	2
4	2	5
     */
    public static void lab12()
    {
        int m = 3;
        int[,] matrix = new int[3, 3];
        for (int i = 0; i < matrix.GetLength(0); i++)//массив ввода
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)//массив вывода
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        if ((matrix[0, 1] == matrix[2, 1]) && (matrix[1, 0] == matrix[1, 1]) && (matrix[1, 0] == matrix[1, 2]) && (matrix[1, 0] == matrix[0, 1]))
            Console.WriteLine("Условие выполнено");
        else { Console.WriteLine("Условие не выполнено"); }
    }
    /*
Ввести двухмерный массив целых чисел. Определить все ли его строки содержат только элементы, расположенные по возрастанию или по убыванию     
     */
    public static void lab13()
    {
        int[,] matrix = new int[3, 3];
        for (int i = 0; i < matrix.GetLength(0); i++)//массив ввода
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)//массив вывода
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        //проверка
        for (int i = 0; i < 3; i++)//в этом массиве на месте элементов записываю значения, где 1 это элемент массива больше, чем следующий, а -1 меньше чем сдежующий
        {
            for (int j = 0; j < 2; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                    matrix[i, j] = -1;
                else if (matrix[i, j] > matrix[i, j + 1])
                    matrix[i, j] = 1;
                else matrix[i, j] = 0;
            }
        }
        Console.WriteLine("Если хотите проверить строки массива на возрастание нажмите 1, а если на убываение, то 0");
        int q;
        q = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                sum = +matrix[i, j];
            }
            sum += sum;
        }
        if ((sum == -2) && (q == 1))
            Console.WriteLine("Все элементы в каждой строке расположены по возрастанию");
        else if ((sum == 2) && (q == 0))
            Console.WriteLine("Все элементы в каждой строке расположены по убыванию");
        else Console.WriteLine("Имеются строки не удовлетворяющие заданному параметру");

//строчки кода для проверки 3 задания
        /*
        if (sum == -1)
            Console.WriteLine("Элементы в строке " + i + " расположены по возрастанию");
        if (sum == 1)
            Console.WriteLine("Элементы в строке " + i + " расположены по убыванию");
        if (sum == 0)
            Console.WriteLine("Элементы в строке " + i + " расположены хаотично");   
        */

    }

    static void Main(string[] args)
    {
        lab11();
        lab12();
        lab13();
    }

}