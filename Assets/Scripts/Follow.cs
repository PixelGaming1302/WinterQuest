using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject Target;
    public float Dis;
    public Animator animator;

    void Update()
    {
        Dis = Vector2.Distance(transform.position , Target.transform.position);

        if(Dis >= 1)
        {
            transform.position = Vector2.MoveTowards(transform.position , Target.transform.position , 7 * Time.deltaTime);
            animator.SetBool("isRunning", true);
        }
        if(Dis < 1)
        {
            animator.SetBool("isRunning", false);
        }
    }
}