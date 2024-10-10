using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSceneBtnController : MonoBehaviour
{
    
    [SerializeField] private StartSceneUiController uiController;
    [SerializeField] private PlayerData playerData;


    public void OnButtonClick()
    {
        uiController.CharacterSelectBtn(playerData);

    }

   

}
