using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHP = 100;
    private int currentHP;
    public FloatEvent onHealthChanged;

    private void Start()
    {
        currentHP = maxHP;
        onHealthChanged?.Invoke(currentHP);
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;
        if (currentHP <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            onHealthChanged?.Invoke(currentHP);
        }
    }
}

