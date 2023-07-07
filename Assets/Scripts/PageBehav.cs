using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PageBehav : MonoBehaviour
{
    [Space(10)]
    public TextMeshProUGUI text;

    [Space(10)]
    public string characterName;
    public int damages;
    public int health;




    private void Start()
    {
        text.text = 
            "Hero " + characterName + " deal " + damages + " \n" +
            "Enemy has only " + health + "\n\n\n" +
            "Will he survive?";
    }

}
