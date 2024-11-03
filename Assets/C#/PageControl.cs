using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PageControl : MonoBehaviour
{
    public AudioSource clickSound;  // 点击按钮时的音效
    public Button loadSceneButton;  // 场景切换的按钮

    public int targetSceneIndex;  // 要跳转的场景索引

    void Start()
    {
        // 绑定按钮点击事件
        if (loadSceneButton != null)
        {
            loadSceneButton.onClick.AddListener(() => StartCoroutine(PlaySoundAndLoadScene(targetSceneIndex)));
            Debug.Log("按钮点击事件已绑定");
        }
        else
        {
            Debug.LogError("未绑定按钮，请检查 Inspector 设置！");
        }
    }

    // 协程：播放音效后延迟加载场景
    private IEnumerator PlaySoundAndLoadScene(int sceneIndex)
    {
        // 播放音效
        if (clickSound != null)
        {
            clickSound.Play();
            Debug.Log("音效已播放");

            // 等待音效播放完成
            yield return new WaitForSeconds(clickSound.clip.length);
        }
        else
        {
            Debug.LogWarning("未设置音效！");
        }

        // 加载目标场景
        SceneManager.LoadScene(sceneIndex);
        Debug.Log("场景已切换到索引：" + sceneIndex);
    }
}
