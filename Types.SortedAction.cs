// A part of the C# Language Syntactic Sugar suite.

using System;
using System.Collections.Generic;

namespace CLSS
{
  /// <summary>
  /// An alias for SortedList&lt;TKey, <see cref="Action"/>&gt;.
  /// A SortedAction can be treated as a delegate that lets you control the 
  /// order-of-execution of its callbacks through their associated keys.
  /// </summary>
  /// <typeparam name="TKey">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='TKey']"/>
  /// </typeparam>
  public partial class SortedAction<TKey> : SortedList<TKey, Action> { }

  /// <summary>
  /// An alias for SortedList&lt;TKey, <see cref="Action{T}"/>&gt;.
  /// A SortedAction can be treated as a delegate that lets you control the 
  /// order-of-execution of its callbacks through their associated keys.
  /// </summary>
  /// <typeparam name="TKey">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='TKey']"/>
  /// </typeparam>
  /// <typeparam name="T1">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T1']"/></typeparam>
  public partial class SortedAction<TKey, T1> : SortedList<TKey, Action<T1>> { }

  /// <summary>
  /// An alias for SortedList&lt;TKey, <see cref="Action{T1, T2}"/>&gt;.
  /// A SortedAction can be treated as a delegate that lets you control the 
  /// order-of-execution of its callbacks through their associated keys.
  /// </summary>
  /// <typeparam name="TKey">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='TKey']"/>
  /// </typeparam>
  /// <typeparam name="T1">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T1']"/></typeparam>
  /// <typeparam name="T2">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T2']"/></typeparam>
  public partial class SortedAction<TKey, T1, T2>
    : SortedList<TKey, Action<T1, T2>>
  { }

  /// <summary>
  /// An alias for SortedList&lt;TKey, <see cref="Action{T1, T2, T3}"/>&gt;.
  /// A SortedAction can be treated as a delegate that lets you control the 
  /// order-of-execution of its callbacks through their associated keys.
  /// </summary>
  /// <typeparam name="TKey">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='TKey']"/>
  /// </typeparam>
  /// <typeparam name="T1">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T1']"/></typeparam>
  /// <typeparam name="T2">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T2']"/></typeparam>
  /// <typeparam name="T3">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T3']"/></typeparam>
  public partial class SortedAction<TKey, T1, T2, T3>
    : SortedList<TKey, Action<T1, T2, T3>>
  { }

  /// <summary>
  /// An alias for SortedList&lt;TKey, <see cref="Action{T1, T2, T3, T4}"/>&gt;.
  /// A SortedAction can be treated as a delegate that lets you control the 
  /// order-of-execution of its callbacks through their associated keys.
  /// </summary>
  /// <typeparam name="TKey">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='TKey']"/>
  /// </typeparam>
  /// <typeparam name="T1">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T1']"/></typeparam>
  /// <typeparam name="T2">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T2']"/></typeparam>
  /// <typeparam name="T3">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T3']"/></typeparam>
  /// <typeparam name="T4">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T4']"/></typeparam>
  public partial class SortedAction<TKey, T1, T2, T3, T4>
    : SortedList<TKey, Action<T1, T2, T3, T4>>
  { }

  /// <summary>
  /// An alias for SortedList&lt;TKey, <see cref="Action{T1, T2, T3, T4, T5}"/>&gt;.
  /// A SortedAction can be treated as a delegate that lets you control the 
  /// order-of-execution of its callbacks through their associated keys.
  /// </summary>
  /// <typeparam name="TKey">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='TKey']"/>
  /// </typeparam>
  /// <typeparam name="T1">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T1']"/></typeparam>
  /// <typeparam name="T2">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T2']"/></typeparam>
  /// <typeparam name="T3">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T3']"/></typeparam>
  /// <typeparam name="T4">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T4']"/></typeparam>
  /// <typeparam name="T5">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T5']"/></typeparam>
  public partial class SortedAction<TKey, T1, T2, T3, T4, T5>
    : SortedList<TKey, Action<T1, T2, T3, T4, T5>>
  { }

  /// <summary>
  /// An alias for SortedList&lt;TKey, <see cref="Action{T1, T2, T3, T4, T5, T6}"/>&gt;.
  /// A SortedAction can be treated as a delegate that lets you control the 
  /// order-of-execution of its callbacks through their associated keys.
  /// </summary>
  /// <typeparam name="TKey">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='TKey']"/>
  /// </typeparam>
  /// <typeparam name="T1">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T1']"/></typeparam>
  /// <typeparam name="T2">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T2']"/></typeparam>
  /// <typeparam name="T3">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T3']"/></typeparam>
  /// <typeparam name="T4">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T4']"/></typeparam>
  /// <typeparam name="T5">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T5']"/></typeparam>
  /// <typeparam name="T6">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T6']"/></typeparam>
  public partial class SortedAction<TKey, T1, T2, T3, T4, T5, T6>
    : SortedList<TKey, Action<T1, T2, T3, T4, T5, T6>>
  { }

  /// <summary>
  /// An alias for SortedList&lt;TKey, <see cref="Action{T1, T2, T3, T4, T5, T6, T7}"/>&gt;.
  /// A SortedAction can be treated as a delegate that lets you control the 
  /// order-of-execution of its callbacks through their associated keys.
  /// </summary>
  /// <typeparam name="TKey">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='TKey']"/>
  /// </typeparam>
  /// <typeparam name="T1">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T1']"/></typeparam>
  /// <typeparam name="T2">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T2']"/></typeparam>
  /// <typeparam name="T3">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T3']"/></typeparam>
  /// <typeparam name="T4">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T4']"/></typeparam>
  /// <typeparam name="T5">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T5']"/></typeparam>
  /// <typeparam name="T6">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T6']"/></typeparam>
  /// <typeparam name="T7">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T7']"/></typeparam>
  public partial class SortedAction<TKey, T1, T2, T3, T4, T5, T6, T7>
    : SortedList<TKey, Action<T1, T2, T3, T4, T5, T6, T7>>
  { }

  /// <summary>
  /// An alias for SortedList&lt;TKey, <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8}"/>&gt;.
  /// A SortedAction can be treated as a delegate that lets you control the 
  /// order-of-execution of its callbacks through their associated keys.
  /// </summary>
  /// <typeparam name="TKey">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='TKey']"/>
  /// </typeparam>
  /// <typeparam name="T1">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T1']"/></typeparam>
  /// <typeparam name="T2">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T2']"/></typeparam>
  /// <typeparam name="T3">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T3']"/></typeparam>
  /// <typeparam name="T4">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T4']"/></typeparam>
  /// <typeparam name="T5">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T5']"/></typeparam>
  /// <typeparam name="T6">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T6']"/></typeparam>
  /// <typeparam name="T7">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T7']"/></typeparam>
  /// <typeparam name="T8">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T8']"/></typeparam>
  public partial class SortedAction<TKey, T1, T2, T3, T4, T5, T6, T7, T8>
    : SortedList<TKey, Action<T1, T2, T3, T4, T5, T6, T7, T8>>
  { }

  /// <summary>
  /// An alias for SortedList&lt;TKey, <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8, T9}"/>&gt;.
  /// A SortedAction can be treated as a delegate that lets you control the 
  /// order-of-execution of its callbacks through their associated keys.
  /// </summary>
  /// <typeparam name="TKey">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='TKey']"/>
  /// </typeparam>
  /// <typeparam name="T1">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T1']"/></typeparam>
  /// <typeparam name="T2">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T2']"/></typeparam>
  /// <typeparam name="T3">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T3']"/></typeparam>
  /// <typeparam name="T4">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T4']"/></typeparam>
  /// <typeparam name="T5">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T5']"/></typeparam>
  /// <typeparam name="T6">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T6']"/></typeparam>
  /// <typeparam name="T7">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T7']"/></typeparam>
  /// <typeparam name="T8">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T8']"/></typeparam>
  /// <typeparam name="T9">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T9']"/></typeparam>
  public partial class SortedAction<TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9>
    : SortedList<TKey, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>>
  { }

  /// <summary>
  /// An alias for SortedList&lt;TKey, <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/>&gt;.
  /// A SortedAction can be treated as a delegate that lets you control the 
  /// order-of-execution of its callbacks through their associated keys.
  /// </summary>
  /// <typeparam name="TKey">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='TKey']"/>
  /// </typeparam>
  /// <typeparam name="T1">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T1']"/></typeparam>
  /// <typeparam name="T2">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T2']"/></typeparam>
  /// <typeparam name="T3">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T3']"/></typeparam>
  /// <typeparam name="T4">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T4']"/></typeparam>
  /// <typeparam name="T5">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T5']"/></typeparam>
  /// <typeparam name="T6">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T6']"/></typeparam>
  /// <typeparam name="T7">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T7']"/></typeparam>
  /// <typeparam name="T8">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T8']"/></typeparam>
  /// <typeparam name="T9">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T9']"/></typeparam>
  /// <typeparam name="T10">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T10']"/></typeparam>
  public partial class SortedAction<TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
    : SortedList<TKey, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>
  { }

  /// <summary>
  /// An alias for SortedList&lt;TKey, <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/>&gt;.
  /// A SortedAction can be treated as a delegate that lets you control the 
  /// order-of-execution of its callbacks through their associated keys.
  /// </summary>
  /// <typeparam name="TKey">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='TKey']"/>
  /// </typeparam>
  /// <typeparam name="T1">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T1']"/></typeparam>
  /// <typeparam name="T2">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T2']"/></typeparam>
  /// <typeparam name="T3">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T3']"/></typeparam>
  /// <typeparam name="T4">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T4']"/></typeparam>
  /// <typeparam name="T5">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T5']"/></typeparam>
  /// <typeparam name="T6">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T6']"/></typeparam>
  /// <typeparam name="T7">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T7']"/></typeparam>
  /// <typeparam name="T8">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T8']"/></typeparam>
  /// <typeparam name="T9">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T9']"/></typeparam>
  /// <typeparam name="T10">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T10']"/></typeparam>
  /// <typeparam name="T11">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T11']"/></typeparam>
  public partial class SortedAction<TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
    : SortedList<TKey, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>
  { }

  /// <summary>
  /// An alias for SortedList&lt;TKey, <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/>&gt;.
  /// A SortedAction can be treated as a delegate that lets you control the 
  /// order-of-execution of its callbacks through their associated keys.
  /// </summary>
  /// <typeparam name="TKey">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='TKey']"/>
  /// </typeparam>
  /// <typeparam name="T1">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T1']"/></typeparam>
  /// <typeparam name="T2">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T2']"/></typeparam>
  /// <typeparam name="T3">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T3']"/></typeparam>
  /// <typeparam name="T4">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T4']"/></typeparam>
  /// <typeparam name="T5">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T5']"/></typeparam>
  /// <typeparam name="T6">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T6']"/></typeparam>
  /// <typeparam name="T7">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T7']"/></typeparam>
  /// <typeparam name="T8">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T8']"/></typeparam>
  /// <typeparam name="T9">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T9']"/></typeparam>
  /// <typeparam name="T10">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T10']"/></typeparam>
  /// <typeparam name="T11">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T11']"/></typeparam>
  /// <typeparam name="T12">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T12']"/></typeparam>
  public partial class SortedAction<TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
    : SortedList<TKey, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>
  { }

  /// <summary>
  /// An alias for SortedList&lt;TKey, <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/>&gt;.
  /// A SortedAction can be treated as a delegate that lets you control the 
  /// order-of-execution of its callbacks through their associated keys.
  /// </summary>
  /// <typeparam name="TKey">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='TKey']"/>
  /// </typeparam>
  /// <typeparam name="T1">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T1']"/></typeparam>
  /// <typeparam name="T2">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T2']"/></typeparam>
  /// <typeparam name="T3">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T3']"/></typeparam>
  /// <typeparam name="T4">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T4']"/></typeparam>
  /// <typeparam name="T5">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T5']"/></typeparam>
  /// <typeparam name="T6">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T6']"/></typeparam>
  /// <typeparam name="T7">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T7']"/></typeparam>
  /// <typeparam name="T8">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T8']"/></typeparam>
  /// <typeparam name="T9">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T9']"/></typeparam>
  /// <typeparam name="T10">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T10']"/></typeparam>
  /// <typeparam name="T11">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T11']"/></typeparam>
  /// <typeparam name="T12">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T12']"/></typeparam>
  /// <typeparam name="T13">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T13']"/></typeparam>
  public partial class SortedAction<TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
    : SortedList<TKey, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>
  { }

  /// <summary>
  /// An alias for SortedList&lt;TKey, <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/>&gt;.
  /// A SortedAction can be treated as a delegate that lets you control the 
  /// order-of-execution of its callbacks through their associated keys.
  /// </summary>
  /// <typeparam name="TKey">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='TKey']"/>
  /// </typeparam>
  /// <typeparam name="T1">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T1']"/></typeparam>
  /// <typeparam name="T2">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T2']"/></typeparam>
  /// <typeparam name="T3">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T3']"/></typeparam>
  /// <typeparam name="T4">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T4']"/></typeparam>
  /// <typeparam name="T5">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T5']"/></typeparam>
  /// <typeparam name="T6">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T6']"/></typeparam>
  /// <typeparam name="T7">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T7']"/></typeparam>
  /// <typeparam name="T8">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T8']"/></typeparam>
  /// <typeparam name="T9">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T9']"/></typeparam>
  /// <typeparam name="T10">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T10']"/></typeparam>
  /// <typeparam name="T11">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T11']"/></typeparam>
  /// <typeparam name="T12">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T12']"/></typeparam>
  /// <typeparam name="T13">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T13']"/></typeparam>
  /// <typeparam name="T14">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T14']"/></typeparam>
  public partial class SortedAction<TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
    : SortedList<TKey, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>
  { }

  /// <summary>
  /// An alias for SortedList&lt;TKey, <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/>&gt;.
  /// A SortedAction can be treated as a delegate that lets you control the 
  /// order-of-execution of its callbacks through their associated keys.
  /// </summary>
  /// <typeparam name="TKey">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='TKey']"/>
  /// </typeparam>
  /// <typeparam name="T1">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T1']"/></typeparam>
  /// <typeparam name="T2">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T2']"/></typeparam>
  /// <typeparam name="T3">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T3']"/></typeparam>
  /// <typeparam name="T4">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T4']"/></typeparam>
  /// <typeparam name="T5">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T5']"/></typeparam>
  /// <typeparam name="T6">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T6']"/></typeparam>
  /// <typeparam name="T7">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T7']"/></typeparam>
  /// <typeparam name="T8">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T8']"/></typeparam>
  /// <typeparam name="T9">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T9']"/></typeparam>
  /// <typeparam name="T10">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T10']"/></typeparam>
  /// <typeparam name="T11">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T11']"/></typeparam>
  /// <typeparam name="T12">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T12']"/></typeparam>
  /// <typeparam name="T13">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T13']"/></typeparam>
  /// <typeparam name="T14">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T14']"/></typeparam>
  /// <typeparam name="T15">
  /// <inheritdoc cref="SortedAction{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"
  /// path="/typeparam[@name='T15']"/></typeparam>
  public partial class SortedAction<TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
    : SortedList<TKey, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>
  { }

  /// <summary>
  /// An alias for SortedList&lt;TKey, <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"/>&gt;.
  /// A SortedAction can be treated as a delegate that lets you control the 
  /// order-of-execution of its callbacks through their associated keys.
  /// </summary>
  /// <typeparam name="TKey">The key type used to sort actions.</typeparam>
  /// <typeparam name="T1">The type of the parameter of the method that this
  /// delegate encapsulates.</typeparam>
  /// <typeparam name="T2">The type of the second parameter of the method that
  /// this delegate encapsulates.</typeparam>
  /// <typeparam name="T3">The type of the third parameter of the method that
  /// this delegate encapsulates.</typeparam>
  /// <typeparam name="T4">The type of the fourth parameter of the method that
  /// this delegate encapsulates.</typeparam>
  /// <typeparam name="T5">The type of the fifth parameter of the method that
  /// this delegate encapsulates.</typeparam>
  /// <typeparam name="T6">The type of the sixth parameter of the method that
  /// this delegate encapsulates.</typeparam>
  /// <typeparam name="T7">The type of the seventh parameter of the method that
  /// this delegate encapsulates.</typeparam>
  /// <typeparam name="T8">The type of the eighth parameter of the method that
  /// this delegate encapsulates.</typeparam>
  /// <typeparam name="T9">The type of the ninth parameter of the method that
  /// this delegate encapsulates.</typeparam>
  /// <typeparam name="T10">The type of the tenth parameter of the method that
  /// this delegate encapsulates.</typeparam>
  /// <typeparam name="T11">The type of the eleventh parameter of the method
  /// that this delegate encapsulates.</typeparam>
  /// <typeparam name="T12">The type of the twelfth parameter of the method that
  /// this delegate encapsulates.</typeparam>
  /// <typeparam name="T13">The type of the thirteenth parameter of the method
  /// that this delegate encapsulates.</typeparam>
  /// <typeparam name="T14">The type of the fourteenth parameter of the method
  /// that this delegate encapsulates.</typeparam>
  /// <typeparam name="T15">The type of the fifteenth parameter of the method
  /// that this delegate encapsulates.</typeparam>
  /// <typeparam name="T16">The type of the sixteenth parameter of the method
  /// that this delegate encapsulates.</typeparam>
  public partial class SortedAction<TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
    : SortedList<TKey, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>
  { }

  public static partial class ExtensionMethods
  {
    /// <inheritdoc cref="Invoke{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(SortedList{TKey, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)"/>
    public static void Invoke<TKey>(this SortedList<TKey, Action> source)
    { foreach (var p in source) p.Value(); }

    /// <inheritdoc cref="Invoke{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(SortedList{TKey, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)"/>
    public static void Invoke<TKey, T1>(
      this SortedList<TKey, Action<T1>> source,
      T1 arg1)
    { foreach (var p in source) p.Value(arg1); }

    /// <inheritdoc cref="Invoke{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(SortedList{TKey, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)"/>
    public static void Invoke<TKey, T1, T2>(
      this SortedList<TKey, Action<T1, T2>> source,
      T1 arg1,
      T2 arg2)
    {
      foreach (var p in source) p.Value(arg1,
        arg2);
    }

    /// <inheritdoc cref="Invoke{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(SortedList{TKey, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)"/>
    public static void Invoke<TKey, T1, T2, T3>(
      this SortedList<TKey, Action<T1, T2, T3>> source,
      T1 arg1,
      T2 arg2,
      T3 arg3)
    {
      foreach (var p in source) p.Value(arg1,
        arg2,
        arg3);
    }

    /// <inheritdoc cref="Invoke{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(SortedList{TKey, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)"/>
    public static void Invoke<TKey, T1, T2, T3, T4>(
      this SortedList<TKey, Action<T1, T2, T3, T4>> source,
      T1 arg1,
      T2 arg2,
      T3 arg3,
      T4 arg4)
    {
      foreach (var p in source) p.Value(arg1,
        arg2,
        arg3,
        arg4);
    }

    /// <inheritdoc cref="Invoke{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(SortedList{TKey, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)"/>
    public static void Invoke<TKey, T1, T2, T3, T4, T5>(
      this SortedList<TKey, Action<T1, T2, T3, T4, T5>> source,
      T1 arg1,
      T2 arg2,
      T3 arg3,
      T4 arg4,
      T5 arg5)
    {
      foreach (var p in source) p.Value(arg1,
        arg2,
        arg3,
        arg4,
        arg5);
    }

    /// <inheritdoc cref="Invoke{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(SortedList{TKey, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)"/>
    public static void Invoke<TKey, T1, T2, T3, T4, T5, T6>(
      this SortedList<TKey, Action<T1, T2, T3, T4, T5, T6>> source,
      T1 arg1,
      T2 arg2,
      T3 arg3,
      T4 arg4,
      T5 arg5,
      T6 arg6)
    {
      foreach (var p in source) p.Value(arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6);
    }

    /// <inheritdoc cref="Invoke{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(SortedList{TKey, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)"/>
    public static void Invoke<TKey, T1, T2, T3, T4, T5, T6, T7>(
      this SortedList<TKey, Action<T1, T2, T3, T4, T5, T6, T7>> source,
      T1 arg1,
      T2 arg2,
      T3 arg3,
      T4 arg4,
      T5 arg5,
      T6 arg6,
      T7 arg7)
    {
      foreach (var p in source) p.Value(arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7);
    }

    /// <inheritdoc cref="Invoke{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(SortedList{TKey, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)"/>
    public static void Invoke<TKey, T1, T2, T3, T4, T5, T6, T7, T8>(
      this SortedList<TKey, Action<T1, T2, T3, T4, T5, T6, T7, T8>> source,
      T1 arg1,
      T2 arg2,
      T3 arg3,
      T4 arg4,
      T5 arg5,
      T6 arg6,
      T7 arg7,
      T8 arg8)
    {
      foreach (var p in source) p.Value(arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7,
        arg8);
    }

    /// <inheritdoc cref="Invoke{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(SortedList{TKey, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)"/>
    public static void Invoke<TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9>(
      this SortedList<TKey, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> source,
      T1 arg1,
      T2 arg2,
      T3 arg3,
      T4 arg4,
      T5 arg5,
      T6 arg6,
      T7 arg7,
      T8 arg8,
      T9 arg9)
    {
      foreach (var p in source) p.Value(arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7,
        arg8,
        arg9);
    }

    /// <inheritdoc cref="Invoke{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(SortedList{TKey, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)"/>
    public static void Invoke<TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
      this SortedList<TKey, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> source,
      T1 arg1,
      T2 arg2,
      T3 arg3,
      T4 arg4,
      T5 arg5,
      T6 arg6,
      T7 arg7,
      T8 arg8,
      T9 arg9,
      T10 arg10)
    {
      foreach (var p in source) p.Value(arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7,
        arg8,
        arg9,
        arg10);
    }

    /// <inheritdoc cref="Invoke{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(SortedList{TKey, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)"/>
    public static void Invoke<TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
      this SortedList<TKey, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> source,
      T1 arg1,
      T2 arg2,
      T3 arg3,
      T4 arg4,
      T5 arg5,
      T6 arg6,
      T7 arg7,
      T8 arg8,
      T9 arg9,
      T10 arg10,
      T11 arg11)
    {
      foreach (var p in source) p.Value(arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7,
        arg8,
        arg9,
        arg10,
        arg11);
    }

    /// <inheritdoc cref="Invoke{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(SortedList{TKey, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)"/>
    public static void Invoke<TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
      this SortedList<TKey, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> source,
      T1 arg1,
      T2 arg2,
      T3 arg3,
      T4 arg4,
      T5 arg5,
      T6 arg6,
      T7 arg7,
      T8 arg8,
      T9 arg9,
      T10 arg10,
      T11 arg11,
      T12 arg12)
    {
      foreach (var p in source) p.Value(arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7,
        arg8,
        arg9,
        arg10,
        arg11,
        arg12);
    }

    /// <inheritdoc cref="Invoke{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(SortedList{TKey, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)"/>
    public static void Invoke<TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
      this SortedList<TKey, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> source,
      T1 arg1,
      T2 arg2,
      T3 arg3,
      T4 arg4,
      T5 arg5,
      T6 arg6,
      T7 arg7,
      T8 arg8,
      T9 arg9,
      T10 arg10,
      T11 arg11,
      T12 arg12,
      T13 arg13)
    {
      foreach (var p in source) p.Value(arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7,
        arg8,
        arg9,
        arg10,
        arg11,
        arg12,
        arg13);
    }

    /// <inheritdoc cref="Invoke{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(SortedList{TKey, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)"/>
    public static void Invoke<TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
      this SortedList<TKey, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> source,
      T1 arg1,
      T2 arg2,
      T3 arg3,
      T4 arg4,
      T5 arg5,
      T6 arg6,
      T7 arg7,
      T8 arg8,
      T9 arg9,
      T10 arg10,
      T11 arg11,
      T12 arg12,
      T13 arg13,
      T14 arg14)
    {
      foreach (var p in source) p.Value(arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7,
        arg8,
        arg9,
        arg10,
        arg11,
        arg12,
        arg13,
        arg14);
    }

    /// <inheritdoc cref="Invoke{TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}(SortedList{TKey, Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}}, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)"/>
    public static void Invoke<TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
      this SortedList<TKey, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> source,
      T1 arg1,
      T2 arg2,
      T3 arg3,
      T4 arg4,
      T5 arg5,
      T6 arg6,
      T7 arg7,
      T8 arg8,
      T9 arg9,
      T10 arg10,
      T11 arg11,
      T12 arg12,
      T13 arg13,
      T14 arg14,
      T15 arg15)
    {
      foreach (var p in source) p.Value(arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7,
        arg8,
        arg9,
        arg10,
        arg11,
        arg12,
        arg13,
        arg14,
        arg15);
    }

    /// <summary>
    /// Invokes the contained actions in the ascending order of their keys.
    /// </summary>
    /// <typeparam name="TKey">The type of key used to sort actions.</typeparam>
    /// <typeparam name="T1">The type of the 1st argument of the contained
    /// actions.</typeparam>
    /// <typeparam name="T2">The type of the 2nd argument of the contained
    /// actions.</typeparam>
    /// <typeparam name="T3">The type of the 3rd argument of the contained
    /// actions.</typeparam>
    /// <typeparam name="T4">The type of the 4th argument of the contained
    /// actions.</typeparam>
    /// <typeparam name="T5">The type of the 4th argument of the contained
    /// actions.</typeparam>
    /// <typeparam name="T6">The type of the 6th argument of the contained
    /// actions.</typeparam>
    /// <typeparam name="T7">The type of the 7th argument of the contained
    /// actions.</typeparam>
    /// <typeparam name="T8">The type of the 8th argument of the contained
    /// actions.</typeparam>
    /// <typeparam name="T9">The type of the 9th argument of the contained
    /// actions.</typeparam>
    /// <typeparam name="T10">The type of the 10th argument of the contained
    /// actions.</typeparam>
    /// <typeparam name="T11">The type of the 11th argument of the contained
    /// actions.</typeparam>
    /// <typeparam name="T12">The type of the 12th argument of the contained
    /// actions.</typeparam>
    /// <typeparam name="T13">The type of the 13th argument of the contained
    /// actions.</typeparam>
    /// <typeparam name="T14">The type of the 14th argument of the contained
    /// actions.</typeparam>
    /// <typeparam name="T15">The type of the 15th argument of the contained
    /// actions.</typeparam>
    /// <typeparam name="T16">The type of the 16th argument of the contained
    /// actions.</typeparam>
    /// <param name="source">The collection of actions to be invoked.</param>
    /// <param name="arg1">The 1st argument for the contained actions.</param>
    /// <param name="arg2">The 2nd argument for the contained actions.</param>
    /// <param name="arg3">The 3rd argument for the contained actions.</param>
    /// <param name="arg4">The 4th argument for the contained actions.</param>
    /// <param name="arg5">The 5th argument for the contained actions.</param>
    /// <param name="arg6">The 6th argument for the contained actions.</param>
    /// <param name="arg7">The 7th argument for the contained actions.</param>
    /// <param name="arg8">The 8th argument for the contained actions.</param>
    /// <param name="arg9">The 9th argument for the contained actions.</param>
    /// <param name="arg10">The 10th argument for the contained actions.</param>
    /// <param name="arg11">The 11th argument for the contained actions.</param>
    /// <param name="arg12">The 12th argument for the contained actions.</param>
    /// <param name="arg13">The 13th argument for the contained actions.</param>
    /// <param name="arg14">The 14th argument for the contained actions.</param>
    /// <param name="arg15">The 15th argument for the contained actions.</param>
    /// <param name="arg16">The 16th argument for the contained actions.</param>
    public static void Invoke<TKey, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
      this SortedList<TKey, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> source,
      T1 arg1,
      T2 arg2,
      T3 arg3,
      T4 arg4,
      T5 arg5,
      T6 arg6,
      T7 arg7,
      T8 arg8,
      T9 arg9,
      T10 arg10,
      T11 arg11,
      T12 arg12,
      T13 arg13,
      T14 arg14,
      T15 arg15,
      T16 arg16)
    {
      foreach (var p in source) p.Value(arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7,
        arg8,
        arg9,
        arg10,
        arg11,
        arg12,
        arg13,
        arg14,
        arg15,
        arg16);
    }
  }
}