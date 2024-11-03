using UnityEngine;

public class PlayAnimationOnButtonClick : MonoBehaviour
{
    public Animator animator;  // ����Animator���
    public string animationTriggerName = "PlayAnimation";  // ������Trigger����

    // ����������ڰ�ť���ʱ����
    public void PlayAnimation()
    {
        if (animator != null)
        {
            animator.SetTrigger(animationTriggerName); // ����Trigger��������������
        }
        else
        {
            Debug.LogWarning("Animator δ���ã���������Ƿ������Animator���");
        }
    }
}
