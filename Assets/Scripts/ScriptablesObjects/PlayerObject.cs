using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Player")]

public class PlayerObject : ScriptableObject
{
    [Header("Variables")]
    public string nameObject;
    public float moveSpeed;
    public float Damage;

    [Header("Movement")]
    public float MoveX;
    public float MoveY;


}
