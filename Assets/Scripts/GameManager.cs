using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Instância um singletoon
    public static GameManager instance;

   
    private void Awake()
    {
       
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Manter o GameManager entre cenas
        }
        else
        {
            Destroy(gameObject);
        }
    }
}