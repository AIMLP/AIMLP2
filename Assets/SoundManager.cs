using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject BackgroundMusic;
    AudioSource backmusic;

    void Awake()
    {   backmusic = this.GetComponent<AudioSource>(); //������� �����ص�
        if (backmusic.isPlaying) return; //��������� ����ǰ� �ִٸ� �н�
        else
        {
            backmusic.Play();
            DontDestroyOnLoad(this); //������� ��� ����ϰ�(���� ��ư�Ŵ������� ����)
        }
    }


}
