using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PageControl : MonoBehaviour
{
    public AudioSource clickSound;  // �����ťʱ����Ч
    public Button loadSceneButton;  // �����л��İ�ť

    public int targetSceneIndex;  // Ҫ��ת�ĳ�������

    void Start()
    {
        // �󶨰�ť����¼�
        if (loadSceneButton != null)
        {
            loadSceneButton.onClick.AddListener(() => StartCoroutine(PlaySoundAndLoadScene(targetSceneIndex)));
            Debug.Log("��ť����¼��Ѱ�");
        }
        else
        {
            Debug.LogError("δ�󶨰�ť������ Inspector ���ã�");
        }
    }

    // Э�̣�������Ч���ӳټ��س���
    private IEnumerator PlaySoundAndLoadScene(int sceneIndex)
    {
        // ������Ч
        if (clickSound != null)
        {
            clickSound.Play();
            Debug.Log("��Ч�Ѳ���");

            // �ȴ���Ч�������
            yield return new WaitForSeconds(clickSound.clip.length);
        }
        else
        {
            Debug.LogWarning("δ������Ч��");
        }

        // ����Ŀ�곡��
        SceneManager.LoadScene(sceneIndex);
        Debug.Log("�������л���������" + sceneIndex);
    }
}
