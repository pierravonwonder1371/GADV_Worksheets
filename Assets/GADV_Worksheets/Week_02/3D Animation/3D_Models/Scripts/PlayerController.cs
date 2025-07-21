using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Animation event handler method
    public void HandleFall()
    {
        Debug.Log("Oof! I didn't expect that!");
    }
}
