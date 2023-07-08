using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerNameGenerator : Generators
{

    public CharacterNamesList namesList;
    

    public override void Generate()
    {
        base.Generate();
        Image newNameObject = Instantiate(preFab);
        newNameObject.rectTransform.SetParent(transform, false);
        newNameObject.rectTransform.anchoredPosition = new Vector3(0, 0, 0);
        newNameObject.GetComponent<DragAndDrop>().canvas = canvas;
        newNameObject.GetComponentInChildren<TextMeshProUGUI>().text = namesList.GetRandomName();

    }


}
