namespace NetMyLibrary
{
    public class Array
    {
        int[] array;
        int size;

        public Array(int size)
        {
            this.size = size;
            array = new int[size];
        }

        public void Init()
        {
            Random random = new Random();
            for(int i = 0; i < size; i++)
                array[i] = random.Next() % 100;
        }

        public void Print()
        {
            for (int i = 0; i < size; i++)
                Console.Write($"{array[i]} ");
            Console.WriteLine();
        }
    }
}
