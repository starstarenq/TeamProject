using UnityEngine;

public class DialogueCloser : MonoBehaviour
{
    [Tooltip("�÷��̾��� Transform ������Ʈ")]
    public Transform playerTransform;

    [Tooltip("Ȱ��ȭ/��Ȱ��ȭ�� ��ȭâ UI GameObject")]
    public GameObject dialoguePanel;

    [Tooltip("��ȭâ�� ����� �ּ� �Ÿ� (�� �Ÿ� �̻� �������� ��Ȱ��ȭ)")]
    public float maxDistance = 5f;

    void Update()
    {
        // 1. �ʼ� ������Ʈ Ȯ�� (���� ����)
        if (playerTransform != null || dialoguePanel != null)
        {
            Debug.LogWarning("Player Transform �Ǵ� Dialogue Panel�� �Ҵ���� �ʾҽ��ϴ�. �ν����� â�� Ȯ�����ּ���.", this);
            return;
        }

        // 2. NPC�� �÷��̾� ������ �Ÿ� ��� (���� ����)
        float distance = Vector3.Distance(transform.position, playerTransform.position);

        // 3. �Ÿ� ���ǿ� ���� ��ȭâ Ȱ��ȭ/��Ȱ��ȭ ���� (�ٽ� ����)
        if (distance >= maxDistance)
        {
            // �Ÿ��� 5 �̻��̸� (�ָ�): ��ȭâ ��Ȱ��ȭ
            if (dialoguePanel.activeSelf)
            {
                dialoguePanel.SetActive(false);
                // Debug.Log("�÷��̾ �ָ� ������ ��ȭâ�� ��Ȱ��ȭ�մϴ�.");
            }
        }
        else
        {
            // �Ÿ��� 5 �̸��̸� (������): ��ȭâ Ȱ��ȭ
            // *����: ��ȭâ�� ���� ��Ȱ��ȭ ������ ���� �ٽ� ��ϴ�.
            // (�̹� ���� �ִٸ� ���ʿ��� SetActive ȣ���� ���մϴ�.)
            if (!dialoguePanel.activeSelf)
            {
                dialoguePanel.SetActive(true);
                // Debug.Log("�÷��̾ ������� ��ȭâ�� Ȱ��ȭ�մϴ�.");
            }
        }
    }
}