using Unity.Cinemachine;
using UnityEngine;

public class Potal : MonoBehaviour
{
    public Transform movePosition;
    public Collider2D mapBoundary;   // Start is called once before the first execution of Update after the MonoBehaviour is created
public CinemachineConfiner2D Confiner;
    public Animator SceneTransitionAnimator;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Confiner.BoundingShape2D = mapBoundary;
            collision.transform.position = movePosition.position;
            SceneTransitionAnimator.SetTrigger("Show");

        }
    }
}
