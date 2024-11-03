using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
    public Button musicToggleButton;  // 音乐控制按钮
    public Sprite musicOnImage;       // 音乐开启图片
    public Sprite musicOffImage;      // 音乐关闭图片
    public AudioSource clickSound;    // 按钮点击提示音
    public AudioSource[] audioSources; // 场景中的所有 AudioSource

    private bool isMusicPlaying = true;  // 音乐是否在播放
    private bool isSoundEnabled = true;  // 音效是否启用

    void Start()
    {
        // 初始化场景中的所有音频源
        audioSources = FindObjectsOfType<AudioSource>();

        // 绑定按钮事件
        if (musicToggleButton != null)
        {
            musicToggleButton.onClick.AddListener(ToggleMusicAndSound);
            UpdateButtonImage();  // 初始化按钮图片
        }
        else
        {
            Debug.LogError("未绑定音乐切换按钮，请检查 Inspector 设置！");
        }
    }

    // 切换音乐和音效的状态
    private void ToggleMusicAndSound()
    {
        isMusicPlaying = !isMusicPlaying;
        isSoundEnabled = isMusicPlaying;  // 音乐关闭时音效也关闭

        // 更新所有音频源的播放状态
        foreach (AudioSource source in audioSources)
        {
            if (source != clickSound)  // 排除当前按钮的提示音
            {
                source.mute = !isSoundEnabled;  // 设置静音状态
                if (isMusicPlaying)
                {
                    source.Play();  // 开启音乐时播放音频
                }
                else
                {
                    source.Pause();  // 关闭音乐时暂停音频
                }
            }
        }

        UpdateButtonImage();  // 更新按钮图片
        PlayClickSound();  // 播放点击音效（若启用）
    }

    // 更新按钮图片
    private void UpdateButtonImage()
    {
        if (isMusicPlaying)
        {
            musicToggleButton.image.sprite = musicOnImage;  // 显示开启音乐的图片
        }
        else
        {
            musicToggleButton.image.sprite = musicOffImage;  // 显示关闭音乐的图片
        }
    }

    // 播放点击音效
    private void PlayClickSound()
    {
        // 仅在音效启用时播放
        if (isSoundEnabled && clickSound != null)
        {
            clickSound.Play();
        }
        else if (clickSound == null)
        {
            Debug.LogWarning("未设置点击音效！");
        }
    }
}