using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutMyselfPage : MonoBehaviour
{
    public void ToAboutMyself()
    {
        if (SceneManager.GetActiveScene().buildIndex != 5)
        {
            SceneManager.LoadScene(5);
        }
    }
    
}
