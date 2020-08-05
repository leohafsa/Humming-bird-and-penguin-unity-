using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class b_menu : MonoBehaviour
{
    public void back_to_agnt()
    {
        SceneManager.LoadScene("Ml_agents");
    }

}
