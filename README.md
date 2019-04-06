# CustomReorderableList

## ReorderableList
- UnityのInspectorで並び替えができるList。
- これを手軽に扱えるようにしたもの。

## 使い方
- [Qiita](https://qiita.com/hide_gugen/items/33a03aa304c1e24e48c5)
- Packageをインポートして`[ReorderableList]`を付けた指定の型を使う。
```c#:Ex1.cs
// Ex.
[ReorderableList]
public LString m_string;
```
```c#:Ex1.cs
// 追加する
m_string.Add("new Text");
// Logで出す
Debug.Log(m_string[0]);
```
