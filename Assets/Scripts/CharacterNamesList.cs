using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Names", menuName = "Names")]
public class CharacterNamesList : ScriptableObject
{
    public string[] names;
    public  string GetRandomName()
    {
        return names[Random.Range(0, names.Length)];
    }

}
