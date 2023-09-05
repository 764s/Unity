Common
=

### 隐式转换
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/user-defined-conversion-operators
```c#
        // FrameEventValue<T>(T value) a = TestEnum.a
        public static implicit operator FrameEventValue<T>(T value) => new FrameEventValue<T>(value);
        
        // FrameEventValue<T>(T value) a = FrameEventValue<TestEnum>TestEnum.a
        public static explicit operator FrameEventValue<T>(T value) => new FrameEventValue<T>(value);
    
        public static implicit operator T(OptionalValue<T> t) => t.Value;
```

### 声明带out的回调
```c#

    public delegate void GetActionState(ActionSubType subType, 
        out ActionStateType targetStateType, 
        out ActionType targetActionType,
        out ActionSubType targetSubType);
        
    public delegate void GetActionState<T, I, J, K>(T subType, 
        out I targetStateType, 
        out J targetActionType,
        out K targetSubType);
```