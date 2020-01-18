using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gamemanager;

    private void OnTriggerEnter(Collider other)
    {
        gamemanager.CompleteLevel();
    }
}
