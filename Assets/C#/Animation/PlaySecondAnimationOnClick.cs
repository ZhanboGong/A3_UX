using UnityEngine;

public class PlaySecondAnimationOnClick : MonoBehaviour
{
    public Animator animator;  // ��Animator�����ֵ������
    private bool firstAnimationPlayed = false;  // ��ǵ�һ�ζ����Ƿ񲥷����

    void Start()
    {
        // ������ʱ�Զ����ŵ�һ�ζ���
        animator.Play("FirstAnimation");
    }

    void Update()
    {
        // ����һ�ζ����Ƿ񲥷����
        if (!firstAnimationPlayed && animator.GetCurrentAnimatorStateInfo(0).IsName("FirstAnimation") &&
            animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
        {
            firstAnimationPlayed = true;  // ��ǵ�һ�ζ����Ѳ������
        }
    }

    private void OnMouseDown()
    {
        // ֻ���ڵ�һ�ζ���������Ϻ�����������ŵڶ��ζ���
        if (firstAnimationPlayed)
        {
            animator.SetTrigger("PlaySecondAnimation");  // ÿ�ε�����������ŵڶ��ζ���
        }
    }
}
