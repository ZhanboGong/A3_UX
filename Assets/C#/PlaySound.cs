using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource audioSource; // ����AudioSource���

    public void Playound() // �붯���¼�ͬ��
    {
        if (audioSource != null && !audioSource.isPlaying) // �����ƵԴ�Ƿ�Ϊ�գ�����Ƶδ����
        {
            audioSource.Play();
        }
    }
}
