/* ------------------------------------------------- */
//
// ReorderableDrawer.cs
// https://github.com/CitrusMikan/CustomReorderableList
//
/* ------------------------------------------------- */

#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(ReorderList),true)]
public class ReorderableDrawer : PropertyDrawer
{
    private const float fixHeigt = 2f;

    // 描画
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        var fieldProp = property.FindPropertyRelative("m_list");
        property.serializedObject.Update();
        EditorGUI.PropertyField(position, fieldProp, label, true);
        property.serializedObject.ApplyModifiedProperties();
    }

    // 描画領域
    public override float GetPropertyHeight (SerializedProperty property, GUIContent label)
    {
        var height = base.GetPropertyHeight(property, label);
        var count = property.FindPropertyRelative("m_list").CountInProperty();
        height = (height + fixHeigt) * (count - 1) + height;
        return height;
    }
}
#endif // UNITY_EDITOR