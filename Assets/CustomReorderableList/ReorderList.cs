/* ------------------------------------------------- */
//
// ReorderList.cs
// https://github.com/CitrusMikan/CustomReorderableList
//
/* ------------------------------------------------- */

using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using UnityEngine;

public class ReorderList { }

[System.Serializable]
public class ReorderList<T> : ReorderList
{
    /// <summary>List&lt;T&gt;</summary>
    [SerializeField] private List<T> m_list = new List<T>();

    /// <summary>Listプロパティ</summary>
    public List<T> List
    {
        get
        {
            if (m_list == null) m_list = new List<T>();
            return m_list;
        }
        set
        {
            if (m_list == null) m_list = new List<T>();
            m_list = value;
        }
    }

    /// <summary>コンストラクタ</summary>
    public ReorderList () { }
    public ReorderList (IEnumerable<T> collection) { m_list = new List<T>(collection); }
    public ReorderList (int capacity) { m_list = new List<T>(capacity); }

    /// <summary>List[index]</summary>
    public T this[int index] { get { return m_list[index]; } set { m_list[index] = value; } }

    /// <summary>List.Count</summary>
    public int Count { get { return m_list.Count; } }
    public int Capacity { get { return m_list.Capacity; } set { m_list.Capacity = value; } }

    /// <summary>List.Add</summary>
    public void Add (T item) { m_list.Add(item); }

    /// <summary>List.AddRange</summary>
    public void AddRange (IEnumerable<T> collection) { m_list.AddRange(collection); }

    /// <summary>List.AsReadOnly</summary>
    public ReadOnlyCollection<T> AsReadOnly () { return m_list.AsReadOnly(); }

    /// <summary>List.BinarySerach</summary>
    public int BinarySearch (T item) { return m_list.BinarySearch(item); }
    /// <summary>List.BinarySerach</summary>
    public int BinarySearch (T item, IComparer<T> comparer) { return m_list.BinarySearch(item, comparer); }
    /// <summary>List.BinarySerach</summary>
    public int BinarySearch (int index, int count, T item, IComparer<T> comparer) { return m_list.BinarySearch(index, count, item, comparer); }
    
    /// <summary>List.Clear</summary>
    public void Clear () { m_list.Clear(); }

    /// <summary>List.Contains</summary>
    public bool Contains (T item) { return m_list.Contains(item); }

    /// <summary>List.ConvertAll</summary>
    public List<TOutput> ConvertAll<TOutput> (Converter<T, TOutput> converter) { return m_list.ConvertAll(converter); }

    /// <summary>List.ConpyTo</summary>
    public void CopyTo (int index, T[] array, int arrayIndex, int count) { m_list.CopyTo(index, array, arrayIndex, count); }
    public void CopyTo (T[] array, int arrayIndex) { m_list.CopyTo(array, arrayIndex); }
    public void CopyTo (T[] array) { m_list.CopyTo(array); }

    /// <summary>List.Exists</summary>
    public void Exists (System.Predicate<T> match) { m_list.Exists(match); }

    /// <summary>List.Find</summary>
    public T Find (Predicate<T> match) { return m_list.Find(match); }

    /// <summary>List.FindAll</summary>
    public List<T> FindAll (Predicate<T> match) { return m_list.FindAll(match); }

    /// <summary>List.FindIndex</summary>
    public int FindIndex (Predicate<T> match) { return m_list.FindIndex(match); }
    public int FindIndex (int startIndex, Predicate<T> match) { return m_list.FindIndex(startIndex, match); }
    public int FindIndex (int startIndex, int count, Predicate<T> match) { return m_list.FindIndex(startIndex, count, match); }

    /// <summary>List.FindLast</summary>
    public T FindLast (Predicate<T> match) { return m_list.FindLast(match); }

    /// <summary>List.FindLastIndex</summary>
    public int FindLastIndex (Predicate<T> match) { return m_list.FindLastIndex(match); }
    public int FindLastIndex (int startIndex, Predicate<T> match) { return m_list.FindLastIndex(startIndex, match); }
    public int FindLastIndex (int startIndex, int count, Predicate<T> match) { return m_list.FindLastIndex(startIndex, count, match); }

    /// <summary>List.ForEach</summary>
    public void ForEach (Action<T> action) { m_list.ForEach(action); }

    /// <summary>List.GetEnumerator</summary>
    public List<T>.Enumerator GetEnumerator () { return m_list.GetEnumerator(); }

    /// <summary>List.GetRange</summary>
    public List<T> GetRange (int index, int count) { return m_list.GetRange(index, count); }

    /// <summary>List.IndexOf</summary>
    public int IndexOf (T item, int index, int count) { return m_list.IndexOf(item, index, count); }
    public int IndexOf (T item, int index) { return m_list.IndexOf(item, index); }
    public int IndexOf (T item) { return m_list.IndexOf(item); }

    /// <summary>List.Insert</summary>
    public void Insert (int index, T item) { m_list.Insert(index, item); }

    /// <summary>List.InsertRange</summary>
    public void InsertRange (int index, IEnumerable<T> collection) { m_list.InsertRange(index, collection); }
    
    /// <summary>List.InserindexOf</summary>
    public int LastIndexOf (T item) { return m_list.LastIndexOf(item); }
    public int LastIndexOf (T item, int index) { return m_list.LastIndexOf(item, index); }
    public int LastIndexOf (T item, int index, int count) { return m_list.LastIndexOf(item, index, count); }

    /// <summary>List.Remove</summary>
    public bool Remove (T item) { return m_list.Remove(item); }

    /// <summary>List.RemoveAll</summary>
    public int RemoveAll (Predicate<T> match) { return m_list.RemoveAll(match); }

    /// <summary>List.RemoveAt</summary>
    public void RemoveAt (int index) { m_list.RemoveAt(index); }

    /// <summary>List.RemoveRange</summary>
    public void RemoveRange (int index, int count) { m_list.RemoveRange(index, count); }

    /// <summary>List.Reverse</summary>
    public void Reverse (int index, int count) { m_list.Reverse(index, count); }
    public void Reverse () { m_list.Reverse(); }

    /// <summary>List.Sort</summary>
    public void Sort (Comparison<T> comparison) { m_list.Sort(comparison); }
    public void Sort (int index, int count, IComparer<T> comparer) { m_list.Sort(index, count, comparer); }
    public void Sort () { m_list.Sort(); }
    public void Sort (IComparer<T> comparer) { m_list.Sort(comparer); }

    /// <summary>List.ToArray</summary>
    public T[] ToArray () { return m_list.ToArray(); }

    /// <summary>List.TrimExcess</summary>
    public void TrimExcess () { m_list.TrimExcess(); }
    
    /// <summary>List.TrueForAll</summary>
    public bool TrueForAll (Predicate<T> match) { return m_list.TrueForAll(match); }

}

// ジェネリッククラスがUnityのInspectorに表示されないのであらかじめ用意。
// System
[System.Serializable] public class LChar : ReorderList<char> { }
[System.Serializable] public class LString : ReorderList<string> { }
[System.Serializable] public class LBool : ReorderList<bool> { }

[System.Serializable] public class LSbyte : ReorderList<sbyte> { }
[System.Serializable] public class LShort : ReorderList<short> { }
[System.Serializable] public class LInt : ReorderList<int> { }
[System.Serializable] public class LLong : ReorderList<long> { }

[System.Serializable] public class LByte : ReorderList<byte> { }
[System.Serializable] public class LUshort : ReorderList<ushort> { }
[System.Serializable] public class LUint : ReorderList<uint> { }
[System.Serializable] public class LUlong : ReorderList<ulong> { }

[System.Serializable] public class LFloat : ReorderList<float> { }
[System.Serializable] public class LDouble : ReorderList<double> { }
[System.Serializable] public class LDecimal : ReorderList<decimal> { }
// UnityEngine
[System.Serializable] public class LGameObject : ReorderList<GameObject> { }
[System.Serializable] public class LTransform : ReorderList<Transform> { }
[System.Serializable] public class LVector2 : ReorderList<Vector2> { }
[System.Serializable] public class LVector3 : ReorderList<Vector3> { }
// 追加
[System.Serializable] public class LText : ReorderList<UnityEngine.UI.Text> {}