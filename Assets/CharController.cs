using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharController : MonoBehaviour
{

    public Animator anim;
    ParticleSystem particleObject; //파티클시스템

    //[SerializeField] Slider hpSlider;
    public Slider hpSlider;
    BE2_VariablesManager _variablesManager;

    void Start()
    {
        hpSlider.value = hpSlider.maxValue;
        anim = GetComponent<Animator>();
        particleObject = GetComponentInChildren<ParticleSystem>();
        _variablesManager = BE2_VariablesManager.instance;
        _variablesManager.AddOrUpdateVariable("플레이어HP", (hpSlider.value).ToString());
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
        _variablesManager.AddOrUpdateVariable("플레이어HP", (hpSlider.value).ToString());
    }

    /*
    private void OnTriggerEnter(Collider other)
    {
   
        if (other.gameObject.layer == LayerMask.NameToLayer("attack"))
        {
            hpSlider.value--;
            //Debug.Log("attack");
        }
        
    }
    */

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

