using UnityEngine;

public class OldManAnimController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Animator animator;

    [Header("Animator Parameters")]
    [SerializeField] private BoxCollider playerdetector;
    [SerializeField] private BoxCollider interactabledetector;

    private int playerInTriggerHash;
    private int interactableContactHash;

    private void Reset()
    {
        animator = GetComponentInChildren<Animator>();
    }

    private void Awake()
    {
        if (animator == null)
        {
            animator = GetComponentInChildren<Animator>();
        }

        if (animator == null)
        {
            Debug.LogError(
                $"[{nameof(OldManAnimController)}] No Animator found on {gameObject.name} or its children.",
                this
            );

            return;
        }
    }

    /// <summary>
    /// Called by the player detection trigger when the player enters.
    /// </summary>
    public void SetPlayerInTrigger(bool isInside)
    {
        if (animator == null)
            return;

        animator.SetBool(playerInTriggerHash, isInside);
    }

    /// <summary>
    /// Called by the interactable detection trigger when an interactable enters.
    /// </summary>
    public void TriggerInteractableReaction()
    {
        if (animator == null)
            return;

        animator.SetTrigger(interactableContactHash);
    }
}
