using UnityEngine;

public class CoinLogic : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        var gm = FindFirstObjectByType<GameManager>();
        gm?.AddCoin();
        Destroy(gameObject);
    }
}
