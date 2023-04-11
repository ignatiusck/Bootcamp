class Program
{
    static void Main() {
        classA objA = new classA(3);

        Console.WriteLine(objA.num);
    }
}
//=====================
class classA 
{
    public int num;

    public classA(int newNum)
    {
        num = newNum;
        Console.WriteLine(newNum);
    }

    public virtual string pintNum()
    {
        return Console.WriteLine("ClassA number : "+ num);
    }
}

//=========================
class classB : classA
{
    public classB(int newNum):base(newNum)
    {
        num = newNum;
        Console.WriteLine(newNum);
    }
}

//===========================
class classC : classA
{
    public ClassC(int newNum):base(newNum)
    {
        num = newNum;
        Console.WriteLine(newNum);
    }
    
    public override string pintNum()
    {
        return Console.WriteLine("ClassC number : "+ num);
    }
}