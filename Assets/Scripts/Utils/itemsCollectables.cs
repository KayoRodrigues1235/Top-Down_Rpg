using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemsCollectables : MonoBehaviour
{

    [SerializeField] private int value;
    private bool hasTriggred;

    private CoinsManager coinManager;

    private void Start()
    {
        coinManager = CoinsManager.instance;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !hasTriggred)
        {
            hasTriggred = true;
            coinManager.ChangeCoins(value);
            Destroy(gameObject);
        }
    }
}
