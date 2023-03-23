using System.Collections;
class Program
{
    public static void Main()
    {
        Inventory inventory = new();

        //input data
        string resultAdd1 = inventory.addData<int>(100);
        string resultAdd2 = inventory.addData<string>("data");
        string resultAdd3 = inventory.addData<double>(12.54);

        Console.WriteLine($"{resultAdd1}, {resultAdd2}, {resultAdd3}");

        //get data
        foreach (var item in inventory.getData())
        {
            Console.WriteLine(item);
        }

        //remove data
        string resultRemove = inventory.removeData<int>(100);
        Console.WriteLine(resultRemove);
        foreach (var item in inventory.getData())
        {
            Console.WriteLine(item);
        }

    }

    class Inventory
    {
        private int capacity;
        private int count;
        private static ArrayList Data;

        public Inventory()
        {
            capacity = 5;
            count = 0;
            Data = new ArrayList();
        }

        //Add Data
        public string addData<T>(T dataIn)
        {
            if (count >= capacity)
            {
                return "inventory is full.";
            }
            else
            {
                if (dataIn is int || dataIn is string || dataIn is double)
                {
                    Data.Add(dataIn);
                    count++;
                    return "Data added.";
                }
                else
                {
                    return "invalid data input.";
                }
            }

        }

        //Get Data
        public ArrayList getData()
        {
            return Data;
        }

        //Remove data
        public string removeData<T1>(T1 data)
        {
            Data.Remove(data);
            return "Data removed.";
        }
    }

    class InventoryBaseDataType<T>
    {
        private int capacity;
        private int count;
        private static List<T> Data;

        public InventoryBaseDataType()
        {
            capacity = 5;
            count = 0;
            Data = new();
        }

        //Add Data
        public string addData(T dataIn)
        {
            if (count >= capacity)
            {
                return "inventory is full.";
            }
            else
            {
                if (dataIn is int || dataIn is string || dataIn is double)
                {
                    Data.Add(dataIn);
                    count++;
                    return "Data added.";
                }
                else
                {
                    return "invalid data input.";
                }
            }

        }

        //Get Data
        public List<T> getData()
        {
            return Data;
        }

        //Remove data
        public string removeData(T data)
        {
            Data.Remove(data);
            return "Data removed.";
        }
    }
}

