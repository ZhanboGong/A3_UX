using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource audioSource; // 拖入AudioSource组件

    public void Playound() // 与动画事件同名
    {
        if (audioSource != null && !audioSource.isPlaying) // 检查音频源是否为空，且音频未播放
        {
            audioSource.Play();
        }
    }
}
