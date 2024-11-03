using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
    public Button musicToggleButton;  // ���ֿ��ư�ť
    public Sprite musicOnImage;       // ���ֿ���ͼƬ
    public Sprite musicOffImage;      // ���ֹر�ͼƬ
    public AudioSource clickSound;    // ��ť�����ʾ��
    public AudioSource[] audioSources; // �����е����� AudioSource

    private bool isMusicPlaying = true;  // �����Ƿ��ڲ���
    private bool isSoundEnabled = true;  // ��Ч�Ƿ�����

    void Start()
    {
        // ��ʼ�������е�������ƵԴ
        audioSources = FindObjectsOfType<AudioSource>();

        // �󶨰�ť�¼�
        if (musicToggleButton != null)
        {
            musicToggleButton.onClick.AddListener(ToggleMusicAndSound);
            UpdateButtonImage();  // ��ʼ����ťͼƬ
        }
        else
        {
            Debug.LogError("δ�������л���ť������ Inspector ���ã�");
        }
    }

    // �л����ֺ���Ч��״̬
    private void ToggleMusicAndSound()
    {
        isMusicPlaying = !isMusicPlaying;
        isSoundEnabled = isMusicPlaying;  // ���ֹر�ʱ��ЧҲ�ر�

        // ����������ƵԴ�Ĳ���״̬
        foreach (AudioSource source in audioSources)
        {
            if (source != clickSound)  // �ų���ǰ��ť����ʾ��
            {
                source.mute = !isSoundEnabled;  // ���þ���״̬
                if (isMusicPlaying)
                {
                    source.Play();  // ��������ʱ������Ƶ
                }
                else
                {
                    source.Pause();  // �ر�����ʱ��ͣ��Ƶ
                }
            }
        }

        UpdateButtonImage();  // ���°�ťͼƬ
        PlayClickSound();  // ���ŵ����Ч�������ã�
    }

    // ���°�ťͼƬ
    private void UpdateButtonImage()
    {
        if (isMusicPlaying)
        {
            musicToggleButton.image.sprite = musicOnImage;  // ��ʾ�������ֵ�ͼƬ
        }
        else
        {
            musicToggleButton.image.sprite = musicOffImage;  // ��ʾ�ر����ֵ�ͼƬ
        }
    }

    // ���ŵ����Ч
    private void PlayClickSound()
    {
        // ������Ч����ʱ����
        if (isSoundEnabled && clickSound != null)
        {
            clickSound.Play();
        }
        else if (clickSound == null)
        {
            Debug.LogWarning("δ���õ����Ч��");
        }
    }
}