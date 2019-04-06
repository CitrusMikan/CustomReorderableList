/* ------------------------------------------------- */
//
// ReorderableListDrawer.cs
// https://github.com/CitrusMikan/CustomReorderableList
//
/* ------------------------------------------------- */

#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditorInternal;

[CustomPropertyDrawer(typeof(ReorderableListAttribute))]
public class ReorderableListDrawer : PropertyDrawer
{
    private ReorderableList reorder;
    private SerializedProperty prop;
    private bool callbackAdd = false;

    // 描画
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        if (prop == null) prop = property;
        if (prop != null)
        {
            reorder = GetList(prop.FindPropertyRelative("m_list"));
            if (!callbackAdd)
            {
                reorder.drawHeaderCallback += DrawHeader;
                reorder.drawElementCallback += DrawElement;
                callbackAdd = true;
            }
            prop.serializedObject.Update();
            reorder.DoList(position);
            prop.serializedObject.ApplyModifiedProperties();
        }
    }

    // 描画領域
	public override float GetPropertyHeight (SerializedProperty property, GUIContent label)
    {
        var fieldProp = property.FindPropertyRelative("m_list");
        return GetList(fieldProp).GetHeight();
    }

	// リストを取得する
	private ReorderableList GetList (SerializedProperty property)
    {
        if(reorder == null)
        {
            reorder = new ReorderableList(property.serializedObject, property);
        }
        return reorder;
    }

	// ヘッダーの描画
	private void DrawHeader (Rect rect)
	{
        EditorGUI.LabelField(rect, prop.displayName);
    }

	// 要素の描画
	private void DrawElement (Rect rect, int index, bool isActive, bool isFocused)
	{
		var elem = prop.FindPropertyRelative("m_list").GetArrayElementAtIndex(index);
		rect.height -= 4;
		rect.y += 2;
        EditorGUI.PropertyField(rect, elem);
    }
}
#endif // UNITY_EDITOR