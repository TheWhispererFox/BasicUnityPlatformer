using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int coinCount;
    
    public IntEvent onCoinChanged;

    public void AddCoin()
    {
        coinCount++;
        onCoinChanged?.Invoke(coinCount);
    }
}
