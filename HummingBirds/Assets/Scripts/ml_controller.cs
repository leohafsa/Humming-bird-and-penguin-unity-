using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ml_controller : MonoBehaviour
{
    public void playPenguin()
    {
        SceneManager.LoadScene("Penguins");
    }
    public void playHummingbird()
    {
        SceneManager.LoadScene("FlowerIsland");
    }
    public void retunagent()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
