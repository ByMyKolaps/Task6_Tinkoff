namespace Task6
{
    public class Program
    {
        public static Tuple<int, int> Task6(long[] studentsHeights)
        {
            int i = -1, j = -1;
            long iValue = 0;
            bool isPossible = true;
            for (int index = 0; index < studentsHeights.Length; index++)
            {
                // Если на i-ом месте все правильно, то двигаемся дальше
                if (studentsHeights[index] % 2 == (index + 1) % 2)
                    continue;
                else
                {

                    // Если мы уже нашли пару элементов, которую нужно поменять,
                    // то одной единственной перестановки не хватит и можно останавливать цикл
                    if (i != -1 && j != -1)
                    {
                        isPossible = false;
                        break;
                    }
                    if (i == -1)
                    {
                        i = index + 1;
                        // Запоминаем, что за число стоит на неправильно позиции
                        iValue = studentsHeights[index];
                    }
                    else
                    {
                        // Если текущее число, стоящее в неправильной позиции, противоположно по четности ранее найденному числу,
                        // то мы нашли пару для перестановки
                        if (iValue % 2 != studentsHeights[index] % 2)
                            j = index + 1;
                    }
                }
            }
            if (i == -1 || j == -1 || i == j || !isPossible)
            {
                // Если последовательность правильная и ее длина больше 3-ех, то выводим 1 и 3
                if (i == -1 && studentsHeights.Length >= 3)
                {
                    i = 1;
                    j = 3;
                }
                else
                    i = j = -1;

            }
            return Tuple.Create(i, j);
        }

        public static long[] GetNumericalInput()
        {
            var parametrs = Console.ReadLine().Split(' ').Select(s => long.Parse(s)).ToArray();
            return parametrs;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                var input = GetNumericalInput();
                var result = Task6(input);
                Console.WriteLine(result.Item1.ToString() + " " + result.Item2.ToString());
            }
        }
    }
}