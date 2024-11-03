using UnityEngine;

public class PlaySecondAnimationOnClick : MonoBehaviour
{
    public Animator animator;  // 将Animator组件赋值到这里
    private bool firstAnimationPlayed = false;  // 标记第一段动画是否播放完成

    void Start()
    {
        // 在启动时自动播放第一段动画
        animator.Play("FirstAnimation");
    }

    void Update()
    {
        // 检测第一段动画是否播放完毕
        if (!firstAnimationPlayed && animator.GetCurrentAnimatorStateInfo(0).IsName("FirstAnimation") &&
            animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
        {
            firstAnimationPlayed = true;  // 标记第一段动画已播放完成
        }
    }

    private void OnMouseDown()
    {
        // 只有在第一段动画播放完毕后才允许点击播放第二段动画
        if (firstAnimationPlayed)
        {
            animator.SetTrigger("PlaySecondAnimation");  // 每次点击都触发播放第二段动画
        }
    }
}
