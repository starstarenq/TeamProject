using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour
{
    public static DialogueSystem Instance { get; private set; }

    public Image portraitImage;
    public TextMeshProUGUI NPCname;
    public TextMeshProUGUI Text;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
    }

    public void TypeText(NPC_Talk npcTalk)
    {
        portraitImage.sprite = npcTalk.dialougeData.Portrait;
        NPCname.text = npcTalk.dialougeData.NPCname;
        Text.text = npcTalk.dialougeData.Text[npcTalk.CurrentTextIndex()];

        npcTalk.IncreaseTextIndex();
    }
}

