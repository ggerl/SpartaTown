using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
  
    void Awake()
    {
        GameManager.instance.CreatePlayer(transform.position);
    }

  
}
