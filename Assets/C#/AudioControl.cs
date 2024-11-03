using UnityEngine;

public class AudioControl : MonoBehaviour
{
    public AudioSource audioSource; // �� AudioSource ���� Inspector ��
    private bool isPlaying = false; // ���ڸ�����Ƶ�Ƿ����ڲ���

    // �ڰ�ť�ĵ���¼��е����������
    public void ToggleAudio()
    {
        if (isPlaying)
        {
            audioSource.Stop(); // ֹͣ������Ƶ
            isPlaying = false;
        }
        else
        {
            audioSource.Play(); // ��ʼ������Ƶ
            isPlaying = true;
        }
    }
}
