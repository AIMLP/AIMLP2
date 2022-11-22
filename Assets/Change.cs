using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change : MonoBehaviour
{
    float delay = 0.1f;

    public void MainChange()
    {
        Invoke("I_MainChange", delay);
    }

    public void LevelChange()
    {
        Invoke("I_LevelChange", delay);
    }

    public void EasyLevelChange()
    {
        Invoke("I_EasyLevelChange", delay);
    }

    public void NormalLevelChange()
    {
        Invoke("I_NormalLevelChange", delay);
    }

    public void HardLevelChange()
    {
        Invoke("I_HardLevelChange", delay);
    }

    public void Easy1Change()
    {
        Invoke("I_Easy1Change", delay);
    }
    public void Easy2Change()
    {
        Invoke("I_Easy2Change", delay);
    }
    public void Easy3Change()
    {
        Invoke("I_Easy3Change", delay);
    }
    public void Easy4Change()
    {
        Invoke("I_Easy4Change", delay);
    }
    public void Easy5Change()
    {
        Invoke("I_Easy5Change", delay);
    }


    public void Normal1Change()
    {
        Invoke("I_Normal1Change", delay);
    }
    public void Normal2Change()
    {
        Invoke("I_Normal2Change", delay);
    }
    public void Normal3Change()
    {
        Invoke("I_Normal3Change", delay);
    }
    public void Normal4Change()
    {
        Invoke("I_Normal4Change", delay);
    }
    public void Normal5Change()
    {
        Invoke("I_Normal5Change", delay);
    }


    public void Hard1Change()
    {
        Invoke("I_Hard1Change", delay);
    }
    public void Hard2Change()
    {
        Invoke("I_Hard2Change", delay);
    }
    public void Hard3Change()
    {
        Invoke("I_Hard3Change", delay);
    }
    public void Hard4Change()
    {
        Invoke("I_Hard4Change", delay);
    }
    public void Hard5Change()
    {
        Invoke("I_Hard5Change", delay);
    }


    public void CostumeMenuChange()
    {
        Invoke("I_CostumeMenuChange", delay);
    }

    /// <summary>
    /// ///////////////////////////////////////////
    /// </summary>

    public void I_MainChange()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void I_LevelChange()
    {
        SceneManager.LoadScene("LevelScene");
    }

    public void I_EasyLevelChange()
    {
        SceneManager.LoadScene("EasyScene");
    }

    public void I_NormalLevelChange()
    {
        SceneManager.LoadScene("NormalScene");
    }
     
    public void I_HardLevelChange()
    {
        SceneManager.LoadScene("HardScene");
    }

    public void I_Easy1Change()
    {
        SceneManager.LoadScene("Easy 1");
    }
    public void I_Easy2Change()
    {
        SceneManager.LoadScene("Easy 2");
    }
    public void I_Easy3Change()
    {
        SceneManager.LoadScene("Easy 3");
    }
    public void I_Easy4Change()
    {
        SceneManager.LoadScene("Easy 4");
    }
    public void I_Easy5Change()
    {
        SceneManager.LoadScene("Easy 5");
    }


    public void I_Normal1Change()
    {
        SceneManager.LoadScene("Normal 1");
    }
    public void I_Normal2Change()
    {
        SceneManager.LoadScene("Normal 2");
    }
    public void I_Normal3Change()
    {
        SceneManager.LoadScene("Normal 3");
    }
    public void I_Normal4Change()
    {
        SceneManager.LoadScene("Normal 4");
    }
    public void I_Normal5Change()
    {
        SceneManager.LoadScene("Normal 5");
    }


    public void I_Hard1Change()
    {
        SceneManager.LoadScene("Hard 1");
    }
    public void I_Hard2Change()
    {
        SceneManager.LoadScene("Hard 2");
    }
    public void I_Hard3Change()
    {
        SceneManager.LoadScene("Hard 3");
    }
    public void I_Hard4Change()
    {
        SceneManager.LoadScene("Hard 4");
    }
    public void I_Hard5Change()
    {
        SceneManager.LoadScene("Hard 5");
    }

    public void I_CostumeMenuChange()
    {
        SceneManager.LoadScene("Costume");
    }
}
