using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator; // 拖入 Animator 组件
    public string animationName; // 输入动画名称
    private bool hasPlayed = false; // 判断动画是否已播放

    private void Start()
    {
        animator.enabled = false; // 场景加载时禁用 Animator 防止动画自启动
    }

    public void PlayAnimation()
    {
        if (!hasPlayed) // 只有在动画未播放过时才会触发
        {
            animator.enabled = true; // 启用 Animator
            animator.Play(animationName); // 播放动画
            hasPlayed = true; // 标记为已播放
        }
    }
}
