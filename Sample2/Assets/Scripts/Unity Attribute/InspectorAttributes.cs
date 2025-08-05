using System;
using System.Collections.Generic;
using UnityEngine;

public class InspectorAttributes : MonoBehaviour
{
    [Header("Score")]
    public int point;
    public int max_point;
    [Header("Info")]
    public string nickname;
    public Job myJob;

    [HideInInspector]
    public int value = 5;

    //[SerializeField]
    //private int asdf = 123;

    [Space(20)][TextArea(3,2)]
    public string text;

    [Flags]
    public enum Job
    {
        ����=1,
        ����=2,
        �ü�=4,
        ������=8
    }

    //public List<Item.>
}
