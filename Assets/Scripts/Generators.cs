using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Generators : MonoBehaviour
{
    public Canvas canvas;
    public Image preFab;

    public virtual void Generate()
    {
        DragAndDrop child = GetComponentInChildren<DragAndDrop>();
        if (child != null) Destroy(child.gameObject); //cruel

    }
}
