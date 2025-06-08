using UnityEngine;

public class BonusTrigger : MonoBehaviour
{
    private Animator animator;
    private readonly static int isInside = Animator.StringToHash("IsInside");

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            animator.SetBool(isInside, true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            animator.SetBool(isInside, false);
    }
}

