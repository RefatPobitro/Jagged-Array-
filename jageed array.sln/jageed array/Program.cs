class Program
{
    static void Main(string[] args)
    {
        int[][] jagged = new int[4][];
        jagged[0] = new int[] { 1, 31, 5, 7, 11, 3 };
        jagged[1] = new int[3];
        jagged[2] = new int[] { 2, 16, 84, 0, 14, 33 };
        jagged[3] = new int[3];
        for (int row = 0; row < 4; row += 2)
        {
            for (int column = 0; column < jagged[row].Length; column += 2)
            {
                Console.Write("{0}    ", jagged[row][column]);
            }
            Console.WriteLine();
        }
        for (int index = 0; index < jagged[1].Length; index += 2)
        {
            jagged[1][index] = jagged[0][index + 2] - jagged[0][index];
        }
        for (int index = 0; index < jagged[3].Length; index++)
        {
            jagged[3][index] = jagged[2][index++] + jagged[2][index + 2];
        }
        for (int row = 1; row < 4; row += 2)
        {
            for (int column = 0; column < jagged[row].Length; column += 2)
            {
                Console.Write("{0}    ", jagged[row][column]);
            }
            Console.WriteLine();
        }
    }
}