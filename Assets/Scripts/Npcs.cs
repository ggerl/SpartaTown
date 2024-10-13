using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.iOS;

public class Npcs : MonoBehaviour
{
    [SerializeField]private NPCData npcData;
    public string name { get; private set; }
    private string dialogue;
    private TMP_Text text;

    private void Awake()
    {
        text = GetComponentInChildren<TMP_Text>();
        name = npcData.Name;
        text.text = npcData.Name;
    }

   







}
