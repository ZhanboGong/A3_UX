using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator; // ���� Animator ���
    public string animationName; // ���붯������
    private bool hasPlayed = false; // �ж϶����Ƿ��Ѳ���

    private void Start()
    {
        animator.enabled = false; // ��������ʱ���� Animator ��ֹ����������
    }

    public void PlayAnimation()
    {
        if (!hasPlayed) // ֻ���ڶ���δ���Ź�ʱ�Żᴥ��
        {
            animator.enabled = true; // ���� Animator
            animator.Play(animationName); // ���Ŷ���
            hasPlayed = true; // ���Ϊ�Ѳ���
        }
    }
}
