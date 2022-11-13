using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CostumeSet : MonoBehaviour
{

    public static int CostumeState = 1;

    public static CostumeSet instance = null;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null) //instance�� null. ��, �ý��ۻ� �����ϰ� ���� ������
        {
            instance = this; //���ڽ��� instance�� �־��ݴϴ�.
            DontDestroyOnLoad(gameObject); //OnLoad(���� �ε� �Ǿ�����) �ڽ��� �ı����� �ʰ� ����
        }
        else
        {
            if (instance != this) //instance�� ���� �ƴ϶�� �̹� instance�� �ϳ� �����ϰ� �ִٴ� �ǹ�
                Destroy(this.gameObject); //�� �̻� �����ϸ� �ȵǴ� ��ü�̴� ��� AWake�� �ڽ��� ����
        }

        if (CostumeState == 1)
            ChangeSet1();
        else if (CostumeState == 2)
            ChangeSet2();
        else if (CostumeState == 3)
            ChangeSet3();
        else if (CostumeState == 4)
            ChangeSet4();
    }



    public void ChangeSet1()
    {
        CostumeState = 1;
        GameObject Set1 = transform.Find("Costume1").gameObject;
        GameObject Set2 = transform.Find("Costume2").gameObject;
        GameObject Set3 = transform.Find("Costume3").gameObject;
        GameObject Set4 = transform.Find("Costume4").gameObject;

        Set1.transform.SetAsFirstSibling();
        Set1.SetActive(true);
        Set2.SetActive(false);
        Set3.SetActive(false);
        Set4.SetActive(false);

        this.gameObject.SetActive(false);
        this.gameObject.SetActive(true);
    }

    public void ChangeSet2()
    {
        CostumeState = 2;
        GameObject Set1 = transform.Find("Costume1").gameObject;
        GameObject Set2 = transform.Find("Costume2").gameObject;
        GameObject Set3 = transform.Find("Costume3").gameObject;
        GameObject Set4 = transform.Find("Costume4").gameObject;

        Set2.transform.SetAsFirstSibling();
        Set1.SetActive(false);
        Set2.SetActive(true);
        Set3.SetActive(false);
        Set4.SetActive(false);

        this.gameObject.SetActive(false);
        this.gameObject.SetActive(true);
    }

    public void ChangeSet3()
    {
        CostumeState = 3;
        GameObject Set1 = transform.Find("Costume1").gameObject;
        GameObject Set2 = transform.Find("Costume2").gameObject;
        GameObject Set3 = transform.Find("Costume3").gameObject;
        GameObject Set4 = transform.Find("Costume4").gameObject;

        Set3.transform.SetAsFirstSibling();
        Set1.SetActive(false);
        Set2.SetActive(false);
        Set3.SetActive(true);
        Set4.SetActive(false);

        this.gameObject.SetActive(false);
        this.gameObject.SetActive(true);
    }

    public void ChangeSet4()
    {
        CostumeState = 4;
        GameObject Set1 = transform.Find("Costume1").gameObject;
        GameObject Set2 = transform.Find("Costume2").gameObject;
        GameObject Set3 = transform.Find("Costume3").gameObject;
        GameObject Set4 = transform.Find("Costume4").gameObject;

        Set4.transform.SetAsFirstSibling();
        Set1.SetActive(false);
        Set2.SetActive(false);
        Set3.SetActive(false);
        Set4.SetActive(true);

        this.gameObject.SetActive(false);
        this.gameObject.SetActive(true);
    }


}
