using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSound : MonoBehaviour
{



    public static bool BlockSoundCheck = false;
    AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (BlockSoundCheck == true)
        {
            audioSource.Play();
            BlockSoundCheck = false;
        }
    }
}
