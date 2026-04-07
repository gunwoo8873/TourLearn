using System;

namespace ReturnValue;

//// Function Main Role
// 1. Main는 `static`이 아닌 멤버는 사용할 수 없다.
// 2. 액세스 한정자를 소유할 수 있다. <Public, Private, Internal, ...etc>
// 3. `void int Task`나 `Task<T>`을 반환할 수 있다.

class Program
{
    static string ReturnValue(string s)
    {
        return s;
    }

    // 
    static async Task<string> AsyncReturnValue(string s)
    {
        await Task.Delay(100);
        return s;
    }

    static async Task<string> OuputAsyncValue()
    {
        return await AsyncReturnValue("Hello World");
    }

    static async Task Main(string[] args)
    {
        Console.WriteLine(ReturnValue("Hello World"));
        Console.WriteLine(await OuputAsyncValue());
    }
}