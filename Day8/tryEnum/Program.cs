using System.Collections;
class Program
{
    enum Price
    {
        regular = 100,
        special = 200,
        luxury = 1999,
    }
    public static void Main()
    {
        Price price = Price.regular;
        Console.WriteLine(price);
        Console.WriteLine((int)price);

        Console.WriteLine();
        foreach (Enum item in Enum.GetValues(typeof(Price)))
        {
            Console.WriteLine($"{(int)(object)item}");
        }

        Console.WriteLine();
        MySequence sequence = new MySequence();
        foreach (int value in sequence)
        {
            Console.WriteLine(value);
        }
    }

    class MySequence : IEnumerable
    {
        private int[] data = { 1, 2, 3, 4, 5 };

        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(data);
        }
        private class MyEnumerator : IEnumerator
        {
            private int[] data;
            private int position = -1;

            public MyEnumerator(int[] data)
            {
                this.data = data;
            }

            public object Current
            {
                get
                {
                    return data[position];
                }
            }

            public bool MoveNext()
            {
                position++;
                return (position < data.Length);
            }

            public void Reset()
            {
                position = -1;
            }
        }
    }
}