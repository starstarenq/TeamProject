// using - : 네임스페이스
// public class 이름 : 클래스
// void start(){} : 함수, 메소드
// 명령문 statement : 코드, 이루어져 있는 구성요소


using UnityEngine;
using UnityEngine.Rendering;

namespace UnityEngine
{
    public class MouseWorld : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
       private void Update()
        {
            // 마우스의 위치를 World 세상으로 바꾸고 싶습니다.
           Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // 컴퓨터에게 명령문
            Physics.Raycast(ray, out RaycastHit hit);                  // 명령문 2 : 광선으로 부터 충돌한
            Debug.Log(hit.point);
            transform.position = hit.point;
        }
    } 
}
// 클래스 밖에 코드 작성 이 코드 MouseWorld 코드 아님