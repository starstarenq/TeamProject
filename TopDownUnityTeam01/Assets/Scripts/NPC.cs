using UnityEngine;

public class NPC : MonoBehaviour
{
    NPC_Talk npcTalk;
    // NPC_Move
    // NPC_Battle

    private void Awake()
    {
        npcTalk = GetComponent<NPC_Talk>();
    }
}
