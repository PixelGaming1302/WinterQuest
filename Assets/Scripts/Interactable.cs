using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Interactable : MonoBehaviour
{
    public enum InteractionMode
    {
        RequireInput,   // Press key (E)
        AutoOnEnter     // Trigger immediately on overlap
    }

    [Header("Interaction")]
    [SerializeField] private InteractionMode interactionMode = InteractionMode.RequireInput;
    [SerializeField] private KeyCode interactKey = KeyCode.E;

    public UnityEvent interactAction;

    private bool isInRange;
    private bool hasTriggered; // prevents double-fire for auto triggers

    void Update()
    {
        if (interactionMode != InteractionMode.RequireInput) return;
        if (!isInRange) return;

        if (Input.GetKeyDown(interactKey))
        {
            Trigger();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) return;

        isInRange = true;

        if (interactionMode == InteractionMode.AutoOnEnter && !hasTriggered)
        {
            hasTriggered = true;
            Trigger();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) return;

        isInRange = false;

        // Reset so it can trigger again if desired
        hasTriggered = false;
    }

    private void Trigger()
    {
            interactAction?.Invoke();
    }
}
