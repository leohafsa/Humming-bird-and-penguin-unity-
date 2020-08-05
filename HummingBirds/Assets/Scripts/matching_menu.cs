using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class matching_menu : MonoBehaviour
{
    public void navi_ChoseLan_Par()
    {
        SceneManager.LoadScene("lang_chose_para");
    }
    public void navi_Paren_world()
    {
        SceneManager.LoadScene("terrain_roll");
    }

    public void navi_MainM()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
