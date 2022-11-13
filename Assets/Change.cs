using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change : MonoBehaviour
{ 

    public void MainChange()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void LevelChange()
    {
        SceneManager.LoadScene("LevelScene");
    }

    public void EasyLevelChange()
    {
        SceneManager.LoadScene("EasyScene");
    }

    public void NormalLevelChange()
    {
        SceneManager.LoadScene("NormalScene");
    }

    public void HardLevelChange()
    {
        SceneManager.LoadScene("HardScene");
    }

    public void EasyMapChange()
    {
        SceneManager.LoadScene("Easy");
    }

    public void NormalMapChange()
    {
        SceneManager.LoadScene("Normal");
    }

    public void HardMapChange()
    {
        SceneManager.LoadScene("Hard");
    }

    public void CostumeMenuChange()
    {
        SceneManager.LoadScene("Costume");
    }
}
