using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuController : MonoBehaviour
{
   public void navi_mlagent()
    {
        SceneManager.LoadScene("Ml_agents");
    }
    public void navi_Cmodel()
    {
        SceneManager.LoadScene("compu_models");
    }
    public void navi_matc_paren()
    {
        SceneManager.LoadScene("matching_paran");
    }
    public void navi_return()
    {
        SceneManager.LoadScene("final_return");
    }

}
