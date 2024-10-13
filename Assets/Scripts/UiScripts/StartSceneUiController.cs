using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartSceneUiController : MonoBehaviour
{
    [SerializeField]private GameObject StartMenuPanel;
    [SerializeField]private GameObject CharacterSelectPanel;
    [SerializeField]private PlayerData _playerData;
    [SerializeField]private Image CurrentImage;
    private string playerName;
    [SerializeField]private TMP_InputField inputField;



    public void Awake()
    {
        ShowCurrentCharacter();

    }

    public void Start()
    {
        inputField.onEndEdit.AddListener(SetPlayerName);
    }
    public void CharacterChoiceBtn()
    {
        StartMenuPanel.SetActive(false);
        CharacterSelectPanel.SetActive(true);

    }

    public void ReturnMainMenu()
    {
        StartMenuPanel.SetActive(true);
        CharacterSelectPanel.SetActive(false);

    }

    public void CharacterSelectBtn(PlayerData playerData)
    {
        _playerData = playerData;
        ShowCurrentCharacter();
    }

    public void ShowCurrentCharacter()
    {
        CurrentImage.sprite = _playerData.characterSprite;
        ReturnMainMenu();

    }

    public void SetPlayerName(string input)
    {
        playerName = input;
    }

    public void OnJoinBtn()
    {
        if(playerName != null && 0 < playerName.Length && playerName.Length < 6) 
        { 
        Debug.Log("Player Name: " + playerName);
        Debug.Log("Player Data: " + (_playerData != null ? "Not Null" : "Null"));
        GameManager.instance.PlayerName = playerName;
        GameManager.instance.playerData = _playerData;
        SceneManager.LoadScene("SampleScene");
        }

    }
    


}

