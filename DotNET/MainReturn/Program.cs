using System;

namespace ReturnValue;

class Program
{
    struct TypeField
    {
        public string s;
        public int n;
    }

    public string Str(string s) => s;
    public int Num(int n) => n;

    static void Main()
    {
        TypeField tf = new TypeField();
        
        tf.s = "String";
        Console.WriteLine($"tf.s: {tf.s}");
        tf.n = 100;
        Console.WriteLine($"tf.n: {tf.n}");

        Program p = new Program();
        
        string s = p.Str("String");
        Console.WriteLine($"s: {s}");
        int n = p.Num(100);
        Console.WriteLine($"n: {n}");
    }
}