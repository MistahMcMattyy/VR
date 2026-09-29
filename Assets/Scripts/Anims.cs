using UnityEngine;

public class CharacterReactions : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Interactable"))
        {
            animator.SetTrigger("Hit");
        }
    }

    public void Taunt()
    {
        animator.SetTrigger("Taunt");
    }
}