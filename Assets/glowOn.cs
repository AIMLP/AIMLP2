using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glowOn : MonoBehaviour
{

    ParticleSystem particleObject; //��ƼŬ�ý���
    // Start is called before the first frame update
    void Start()
    {
        particleObject = GetComponentInChildren<ParticleSystem>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Clear");
        this.particleObject.Play();

    }





}
