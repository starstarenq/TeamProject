using UnityEngine;

public class Door : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // (1) 카메라가 잠시 어두워진다. 카메라 앞에 검은색 종이를 배치.
        // (2) 일정 시간 뒤에 밝아진다.
        // (3) 플레이어가 어떤 위치에서 등장.

        // CinemachineConfiner2D -> BoundingShape A1 -> A1-1 (건물안의 경계선 바꾼다)
        // 위치를 이동? 어디로 이동할지 기억 플레이어의 현재 위치를 해당 위치로 이동시킨다.
        // player, transform.position = 저장된 위치 ;
    }
}
