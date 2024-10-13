using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;

public class MainSceneUiController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private TMP_Text CurrentPlayerText;
    private GameObject player;
    [SerializeField] private GameObject npc;
    private TMP_Text nameText;
    [SerializeField] private GameObject npcDialogue;

    private void Awake()
    {
        player = GameManager.instance.player;
    }

    private void Start()
    {
        DisplayName();
    }
    private void Update()
    {
        DateTime currentTime = DateTime.Now;

        string timeString = currentTime.ToString("HH:mm");

        timeText.text = timeString;

        ComparePositions();
    }

    public void DisplayName()
    {
        GameObject[] NpcArray = GameObject.FindGameObjectsWithTag("NPC");

        StringBuilder nameBuilder = new StringBuilder();

        nameBuilder.AppendLine(GameManager.instance.PlayerName);

        
        
        foreach(GameObject npc in NpcArray)
        {
            nameText = npc.GetComponentInChildren<TMP_Text>(); 
            nameBuilder.AppendLine(nameText.text);

        }

        CurrentPlayerText.text = nameBuilder.ToString();
    }

    private void ComparePositions()
    {
        
        float distance = Vector2.Distance(player.transform.position, npc.transform.position);

        if (distance < 5f) 
        {

            npcDialogue.SetActive(true);
        }
        else
        {

            npcDialogue.SetActive(false);
        }
    }
}
