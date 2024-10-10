using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainSceneBtnController : MonoBehaviour
{
    [SerializeField] private PlayerData _playerData;
    [SerializeField] private PlayerInputController playerInputController;
    [SerializeField] private GameObject selectPanel;
    [SerializeField] private GameObject nameChangePanel;
    [SerializeField] private TMP_InputField inputText;
   

    public void OnButtonClick()
    {
        GameManager.instance.playerData = _playerData;
        playerInputController.PlayerAnimChange("Player_Idle", GameManager.instance.playerData.clip_Idle);
        playerInputController.PlayerAnimChange("Player_Move", GameManager.instance.playerData.clip_Run);
        selectPanel.SetActive(false);
    }

    public void OnCharacterSelectBtn()
    {
        selectPanel.SetActive(true);

    }

    public void OnNameChangeBtn()
    {
        nameChangePanel.SetActive(true);

    }

    public void ChangePlayerName()
    {
        string userName = inputText.text;
        GameManager.instance.PlayerName = userName;
        playerInputController.DisplayPlayerName();
        nameChangePanel.SetActive(false);
    }
}
