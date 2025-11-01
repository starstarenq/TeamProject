using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private NPC_Talk currentNpc;
    private bool CanTalk;

    public void Interact()
    {
        if(CanTalk)
        {
            DialogueSystem.Instance.TypeText(currentNpc);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<NPC_Talk>(out var talk))
        {
            currentNpc = talk;
            CanTalk = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<NPC_Talk>(out var talk))
        {
            currentNpc = null;
            CanTalk = false;
        }
    }
}
