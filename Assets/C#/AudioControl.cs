using UnityEngine;

public class AudioControl : MonoBehaviour
{
    public AudioSource audioSource; // 将 AudioSource 拖入 Inspector 中
    private bool isPlaying = false; // 用于跟踪音频是否正在播放

    // 在按钮的点击事件中调用这个方法
    public void ToggleAudio()
    {
        if (isPlaying)
        {
            audioSource.Stop(); // 停止播放音频
            isPlaying = false;
        }
        else
        {
            audioSource.Play(); // 开始播放音频
            isPlaying = true;
        }
    }
}
