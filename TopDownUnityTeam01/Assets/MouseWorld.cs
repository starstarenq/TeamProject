// using - : ���ӽ����̽�
// public class �̸� : Ŭ����
// void start(){} : �Լ�, �޼ҵ�
// ��ɹ� statement : �ڵ�, �̷���� �ִ� �������


using UnityEngine;
using UnityEngine.Rendering;

namespace UnityEngine
{
    public class MouseWorld : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
       private void Update()
        {
            // ���콺�� ��ġ�� World �������� �ٲٰ� �ͽ��ϴ�.
           Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // ��ǻ�Ϳ��� ��ɹ�
            Physics.Raycast(ray, out RaycastHit hit);                  // ��ɹ� 2 : �������� ���� �浹��
            Debug.Log(hit.point);
            transform.position = hit.point;
        }
    } 
}
// Ŭ���� �ۿ� �ڵ� �ۼ� �� �ڵ� MouseWorld �ڵ� �ƴ�