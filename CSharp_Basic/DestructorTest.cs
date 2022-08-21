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
    // * 1 정확한 시점은 정의되지 않는다.
    
    // 종료자가 실행되는 정확한 시간은 정의되지 않습니다. 클래스 인스턴스에 대한 리소스의 결정적 릴리스를 보장하려면 메서드를 Close 구현하거나
    // 구현을 IDisposable.Dispose 제공합니다.
    //
    // 한 개체가 다른 개체를 참조하더라도 두 개체의 종료자는 특정 순서로 실행되지 않습니다. 즉, 개체 A에 개체 B에 대한 참조가 있고 둘 다
    // 종료자가 있는 경우 개체 A의 종료자가 시작될 때 개체 B가 이미 종료되었을 수 있습니다.
    //
    // 종료자가 실행되는 스레드는 지정되지 않습니다.
    
    // * 2 전혀 실행되지 않을 수 있다.
    
    // 다른 종료자가 무기한으로 차단되는 경우(무한 루프로 들어가서 가져올 수 없는 잠금을 가져오려고 시도합니다. 등). 런타임이 완료될 때
    // 종료자를 실행하려고 하기 때문에 종료자가 무기한 차단되면 다른 종료자가 호출되지 않을 수 있습니다.
    //
    // 런타임에 정리 기회를 주지 않고 프로세스가 종료되는 경우 이 경우 런타임의 프로세스 종료에 대한 첫 번째 알림은 DLL_PROCESS_DETACH 알림입니다.
    
    // * 3 Safe Handle 에 대해 추가적인 확인이 필요하다.
}