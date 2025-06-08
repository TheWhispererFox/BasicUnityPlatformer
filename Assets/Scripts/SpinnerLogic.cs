using UnityEngine;

public class SpinnerLogic : MonoBehaviour
{
    public int damage = 25;
    public float speed = 1.0f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth health = collision.gameObject.GetComponent<PlayerHealth>();
            if (health != null)
                health.TakeDamage(damage);
        }
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(new Vector3(.0f, speed, .0f));
    }
}
