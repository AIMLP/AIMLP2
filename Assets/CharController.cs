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
    BE2_VariablesManager _variablesManager;

    public GameObject gameOverText;     //


    void Start()
    {
        hpSlider.value = hpSlider.maxValue;
        anim = GetComponent<Animator>();
        particleObject = GetComponentInChildren<ParticleSystem>();
        _variablesManager = BE2_VariablesManager.instance;
        _variablesManager.AddOrUpdateVariable("�÷��̾�HP", (hpSlider.value).ToString());
        gameOverText.SetActive(false);    //
    }

    // Update is called once per frame
    void Update()
    {
 
        if (hpSlider.value <= 0)
        {
            anim.Play("Die");        
            Invoke("DestroyPlayer", 1f);

        }
        _variablesManager.AddOrUpdateVariable("�÷��̾�HP", (hpSlider.value).ToString());
    }



    public void DestroyPlayer()
    {

        gameObject.SetActive(false);

        gameOverText.SetActive(true);
        Destroy(gameObject);

    }

}

