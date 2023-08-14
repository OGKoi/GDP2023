using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSignupSystem : MonoBehaviour
{

    public static List<GameObject> events = new List<GameObject>();
    public GameObject signupPrompt;


    public void OnClickEvent()
    {
        signupPrompt.SetActive(true);
    }

    public void CancelEvent()
    {
        signupPrompt.SetActive(false);
    }

    public void OnClickSignUp()
    {

    }
}
