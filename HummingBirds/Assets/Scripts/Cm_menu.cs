using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cm_menu : MonoBehaviour
{
    public void navi_LC()
    {
        SceneManager.LoadScene("language_palin");
    }
    public void navi_PW()
    {
        SceneManager.LoadScene("Mini_game");
    }
    public void navi_MM()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
