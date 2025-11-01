using UnityEngine;

public class DialogueCloser : MonoBehaviour
{
    [Tooltip("플레이어의 Transform 컴포넌트")]
    public Transform playerTransform;

    [Tooltip("활성화/비활성화할 대화창 UI GameObject")]
    public GameObject dialoguePanel;

    [Tooltip("대화창이 사라질 최소 거리 (이 거리 이상 떨어지면 비활성화)")]
    public float maxDistance = 5f;

    void Update()
    {
        // 1. 필수 컴포넌트 확인 (변경 없음)
        if (playerTransform != null || dialoguePanel != null)
        {
            Debug.LogWarning("Player Transform 또는 Dialogue Panel이 할당되지 않았습니다. 인스펙터 창을 확인해주세요.", this);
            return;
        }

        // 2. NPC와 플레이어 사이의 거리 계산 (변경 없음)
        float distance = Vector3.Distance(transform.position, playerTransform.position);

        // 3. 거리 조건에 따른 대화창 활성화/비활성화 로직 (핵심 수정)
        if (distance >= maxDistance)
        {
            // 거리가 5 이상이면 (멀면): 대화창 비활성화
            if (dialoguePanel.activeSelf)
            {
                dialoguePanel.SetActive(false);
                // Debug.Log("플레이어가 멀리 떨어져 대화창을 비활성화합니다.");
            }
        }
        else
        {
            // 거리가 5 미만이면 (가까우면): 대화창 활성화
            // *주의: 대화창이 현재 비활성화 상태일 때만 다시 웁니다.
            // (이미 켜져 있다면 불필요한 SetActive 호출을 피합니다.)
            if (!dialoguePanel.activeSelf)
            {
                dialoguePanel.SetActive(true);
                // Debug.Log("플레이어가 가까워져 대화창을 활성화합니다.");
            }
        }
    }
}