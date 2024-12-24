using UnityEngine;

public class TalkAnimation : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Talk()
    {
        anim.SetTrigger("Talk");
    }
}
