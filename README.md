# CLSS.Types.SortedAction

### Problem

The default `System.Action` delegate determines order-of-execution by registration order. This can be inflexible for the system you are building.

### Solution

`SortedAction` determines order-of-execution by the key you associate with each action.

When you declare a `SortedAction` instance, the first type to give it is the key type, called `TKey`. This type will determine the memory footprint of the keys and the number of possible key values. Types following `TKey` are argument types.

`Tkey` can be any type, but preferably types that implement [`System.IComparable<T>`](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable-1).

`SortedAction` inherits from [`SortedList`](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.sortedlist-2) and uses its methods for adding and removing elements.

**Example**:

```csharp
using CLSS;

var OnEvent = new SortedAction<byte, int, string>();
OnEvent.Add(93, (n, s) => Console.WriteLine($"3rd action"));
OnEvent[25] = (n, s) => Console.WriteLine($"1st action");
OnEvent[68] = (n, s) => Console.WriteLine($"2nd action");
OnEvent.Invoke(16, "foo");
// Output:
// 1st action
// 2nd action
// 3rd action
```

**Note #1**: Upon `using CLSS;`, `Invoke` syntax will also be available to all of the following types: `SortedList<TKey, Action>`, `SortedList<TKey, Action<T>>`, `SortedList<TKey, Action<T1, T2>>`, etc...

**Note #2**: Unlike most CLSS packages which target minimum .NET Standard 1.0, this package targets minimum .NET Standard 1.3.

##### This package is a part of the [C# Language Syntactic Sugar suite](https://github.com/tonygiang/CLSS).