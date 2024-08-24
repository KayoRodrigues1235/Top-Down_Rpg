using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerBase : MonoBehaviour
{
    public PlayerObject PlayerManager;

    #region References
    public string nameObject;
    public float Damage;
    public float moveSpeed;
    public Rigidbody2D rb;
    public float MoveX, MoveY;

    #endregion

    private void Start()
    {
        nameObject = PlayerManager.nameObject;
        Damage = PlayerManager.Damage;
        moveSpeed = PlayerManager.moveSpeed;

        rb = GetComponent<Rigidbody2D>();

    }

    public void Update()
    {
        HandleMovement();   
    }

    public void HandleMovement()
    {
        MoveX = Input.GetAxisRaw("Horizontal") * moveSpeed;
        MoveY = Input.GetAxisRaw("Vertical") * moveSpeed;
        rb.velocity = new Vector2(MoveX, MoveY);
    }

}
