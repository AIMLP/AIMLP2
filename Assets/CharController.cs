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

    public GameObject gameOverText;
    public GameObject clearText;
    Vector3 playerPos;
    Quaternion playerRot;


    void Start()
    {
        hpSlider.value = hpSlider.maxValue;
        playerPos = transform.position;     //
        playerRot = transform.rotation;     //
        anim = GetComponent<Animator>();
        particleObject = GetComponentInChildren<ParticleSystem>();
        _variablesManager = BE2_VariablesManager.instance;
        _variablesManager.AddOrUpdateVariable("플레이어HP", (hpSlider.value).ToString());
        gameOverText.SetActive(false);
        clearText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
 
        if (hpSlider.value <= 0)
        {
            anim.Play("Die_SwordShield");
            Invoke("DestroyPlayer", 1f);
           
        }
        _variablesManager.AddOrUpdateVariable("플레이어HP", (hpSlider.value).ToString());
    }



    public void DestroyPlayer()
    {

        gameObject.SetActive(false);
        gameOverText.SetActive(true);
        transform.position = playerPos;
        transform.rotation = playerRot;

    }

    public void ResetPlayer()
    {
        gameObject.SetActive(false);
        transform.position = playerPos;
        transform.rotation = playerRot;
    }

}

