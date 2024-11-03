using UnityEngine;

public class PlayAnimationOnButtonClick : MonoBehaviour
{
    public Animator animator;  // 拖入Animator组件
    public string animationTriggerName = "PlayAnimation";  // 动画的Trigger名称

    // 这个方法会在按钮点击时调用
    public void PlayAnimation()
    {
        if (animator != null)
        {
            animator.SetTrigger(animationTriggerName); // 设置Trigger参数，触发动画
        }
        else
        {
            Debug.LogWarning("Animator 未设置，请检查对象是否关联了Animator组件");
        }
    }
}
