using System.Diagnostics;

namespace CSharp_Basic;

/// <summary>
/// 소멸자 동작 테스트
/// </summary>
public class DestructorTest
{
    private Stopwatch _sw;
    public DestructorTest()
    {
        _sw = Stopwatch.StartNew();
        Console.WriteLine("Instantiated object");
    }

    public void ShowDuration()
    {
        Console.WriteLine($"This instance of {this} has been in existence for {_sw.Elapsed}");
    }

    ~DestructorTest()
    {
        Console.WriteLine("Finalizing object");
        _sw.Stop();
        Console.WriteLine($"This instance of {this} has been in existence for {_sw.Elapsed}");
    }
}