using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{

    public Slider HSlider;
    private float state;
    GameObject Player;


    public Animator anim;
    ParticleSystem particleObject; //��ƼŬ�ý���

    [SerializeField] Slider hpSlider;




    void Start()
    {
        hpSlider.value = hpSlider.maxValue;
        state = hpSlider.maxValue;
        anim = GetComponent<Animator>();
        particleObject = GetComponentInChildren<ParticleSystem>();

        Player = GameObject.Find("SwordAndShield");
    }




    // Update is called once per frame
    void Update()
    { 
        if (Player == null)          //
        {
            //    Invoke("DestroyEnemy", 3f);
            DestroyEnemy();
        }


        if (Player)
        {
            float distance = Vector3.Distance(Player.transform.position, transform.position);

            if (distance <= 1.2 && distance != 0)
            {
                if (hpSlider.value == state)
                {
                    Attack();
                }
                else
                {
                    anim.Play("DefendGetHit");
                    Invoke("GetBack", 1f);

                }
            }
        }


        if (hpSlider.value <= 0)
        {
            anim.Play("Die");
            anim.SetTrigger("Die");
            this.particleObject.Play();
            Invoke("StopParticle", 0.1f);
            Invoke("DestroyEnemy", 1f);
        }

    }



    void GetBack()
    {
        state = hpSlider.value;
    }



    void Attack()
    {
        CharController HSlider = GameObject.Find("SwordAndShield").GetComponent<CharController>();

        anim.Play("Attack01");
        HSlider.hpSlider.value -= 0.07f;


    }



    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.layer == LayerMask.NameToLayer("attack"))
        {
            hpSlider.value--;
        }

    }


    private void StopParticle()
    {
        this.particleObject.Stop();
    }

    private void DestroyEnemy()
    {

        gameObject.SetActive(false);
        Destroy(gameObject);
    }
}