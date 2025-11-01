using UnityEngine;

public class Test : MonoBehaviour
{
    public NPC_Talk npc_talk;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DialogueSystem.Instance.TypeText(npc_talk);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            DialogueSystem.Instance.TypeText(npc_talk);
        }
    }
}
