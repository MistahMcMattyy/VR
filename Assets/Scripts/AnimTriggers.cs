using UnityEngine;

public class TauntTrigger : MonoBehaviour
{
    [SerializeField] private Animator characterAnimator;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered by: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("PLAYER FOUND");
            characterAnimator.SetBool("Taunt", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            characterAnimator.SetBool("Taunt", false);
        }
    }
}