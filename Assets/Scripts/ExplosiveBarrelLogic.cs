using UnityEngine;

public class ExplosiveBarrelLogic : MonoBehaviour
{
    public float requiredImpactForce = 5f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude >= requiredImpactForce &&
            collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}
