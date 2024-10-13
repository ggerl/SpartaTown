using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NpcData", menuName = "ScriptableObjects/NpcData", order = 2)]

public class NPCData : ScriptableObject
{
    public string Name;
    public string dialogue;

}
