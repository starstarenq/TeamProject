using UnityEngine;

public class NPC_Talk : MonoBehaviour
{
    [System.Serializable]
    public class DialougeData
    {
        // 이름 - 문자열
        public Sprite Portrait;
        public string NPCname;
        [TextArea]
        public string[] Text;
        public int TextIndex;
    }

    public DialougeData dialougeData;
    public bool IsTalkLoop;

    public int CurrentTextIndex() => dialougeData.TextIndex;
    public void IncreaseTextIndex()
    {
        dialougeData.TextIndex = dialougeData.TextIndex + 1;

        if(dialougeData.TextIndex == dialougeData.Text.Length)
        {
            if(IsTalkLoop)
            {
                dialougeData.TextIndex = 0; // 마지막 대사를 계속 반복하라.
            }
            else
            {
                dialougeData.TextIndex = dialougeData.Text.Length - 1; // 마지막 대사를 계속 반복하라.
            }          
        }
    }
}

