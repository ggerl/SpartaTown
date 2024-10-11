using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.Animations;
using UnityEditor.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject player;
    public PlayerData playerData;
    public string PlayerName = "";
    public GameObject PlayerPrefabs;

    private void Awake()
    {


        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);    
        }
    }

    public void CreatePlayer(Vector2 spawnPoint)
    {
        player = Instantiate(PlayerPrefabs, spawnPoint, Quaternion.identity);

    }


 


}
