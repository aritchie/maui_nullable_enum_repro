using System.Collections.Generic;

namespace Repro;

public class MainViewModel
{
    public MainViewModel()
    {
        this.Tests =
        [
            new TestObject("Hello", TestEnum.Hello, TestEnum.Hello),
            new TestObject("Hello", null, TestEnum.Hello),
            new TestObject("Goodbye", TestEnum.Goodbye, TestEnum.Goodbye),
            new TestObject("World", TestEnum.World, TestEnum.World)
            
        ];
    }
    
    public List<TestObject> Tests { get; }
}


public record TestObject(
    string TextFromViewModel, 
    TestEnum? TheValueFromViewModel,
    TestEnum NonNullEnumFromViewModel
);

public enum TestEnum
{
    Hello,
    Goodbye,
    World
}