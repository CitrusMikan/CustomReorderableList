using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    [Header("System")]
    [ReorderableList]
    public LString m_string;
    [ReorderableList]
    [HideInInspector]
    public LFloat m_float;
    [ReorderableList]
    public LBool m_bool;
    [Header("UnityEngine")]
    [ReorderableList]
    public LGameObject m_gameObject;
    [ReorderableList]
    public LVector2 m_vector2;
    [ReorderableList]
    public LVector3 m_vector3;

    // Use this for initialization
    void Start ()
	{
    }

    // Update is called once per frame
    void Update()
    {
    }
}
