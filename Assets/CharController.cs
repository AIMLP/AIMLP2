using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharController : MonoBehaviour
{

    public Animator anim;
    ParticleSystem particleObject; //��ƼŬ�ý���

    //[SerializeField] Slider hpSlider;
    public Slider hpSlider;

    void Start()
    {
        hpSlider.value = hpSlider.maxValue;
        anim = GetComponent<Animator>();
        particleObject = GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(hpSlider.value);
        if (hpSlider.value <= 0)
        {
            anim.Play("Die");
            //anim.SetTrigger("Die");               
            //this.particleObject.Play();                   
            //Invoke("StopParticle", 0.1f);         
            Invoke("DestroyPlayer", 1f);

        }

    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("attack"); 

        
        if (other.gameObject.layer == LayerMask.NameToLayer("attack"))
        {
            hpSlider.value--;
            //Debug.Log("attack");
        }
        
    }

    /*
    private void StopParticle()                                    
    {
        this.particleObject.Stop();
    }
    */

    private void DestroyPlayer()
    {

        gameObject.SetActive(false);
        Destroy(gameObject);
    }
    
}
