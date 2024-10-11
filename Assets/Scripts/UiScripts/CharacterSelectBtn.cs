using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectBtn : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;
    [SerializeField] private MainSceneBtnController mainSceneBtnController;
        
    public void Onclick()
    {
        mainSceneBtnController.CharacterChange(playerData);

    }
}
