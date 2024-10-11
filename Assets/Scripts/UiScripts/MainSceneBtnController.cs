using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainSceneBtnController : MonoBehaviour
{
    [SerializeField] private GameObject selectPanel;
    [SerializeField] private GameObject nameChangePanel;
    [SerializeField] private TMP_InputField inputText;
    [SerializeField] private GameObject CurrentPlayerPanel;
    private PlayerInputController playerInputController;


    private void Start()
    {
        playerInputController = GameManager.instance.player.GetComponent<PlayerInputController>();
    }
    public void CharacterChange(PlayerData _playerData)
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

    public void OnCurretPlayerBtn()
    {
        Debug.Log("Ŭ���Ǿ����ϴ�");
        CurrentPlayerPanel.SetActive(true);

    }

    public void CloseCurrentPlayerBtn()
    {
        CurrentPlayerPanel.SetActive(false);

    }
}
