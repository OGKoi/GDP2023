using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventSignupSystem : MonoBehaviour
{
    public static bool[] signupCheck = new bool[3] {false, false, false};
    public Button preview1;
    public Button preview2;
    public Button preview3;
    public GameObject eventsignup1;
    public GameObject eventsignup2;
    public GameObject eventsignup3;
    public Button signupButton;
    public Button cancelButton;



    public void OnClickEvent()
    {
        if (gameObject == preview1)
        {
            eventsignup1.SetActive(true);
            signupButton.gameObject.SetActive(true);
            cancelButton.gameObject.SetActive(true);
        }
        else if (gameObject == preview2)
        {
            eventsignup2.SetActive(true);
            signupButton.gameObject.SetActive(true);
            cancelButton.gameObject.SetActive(true);
        }
        else if (gameObject == preview3)
        {
            eventsignup3.SetActive(true);
            signupButton.gameObject.SetActive(true);
            cancelButton.gameObject.SetActive(true);

        }    
    }

    public void CancelEvent()
    {
        if (eventsignup1.activeSelf == true)
        {
            eventsignup1.SetActive(false);
            signupButton.gameObject.SetActive(false);
            cancelButton.gameObject.SetActive(false);
        }
        else if (eventsignup2.activeSelf == true)
        {
            eventsignup2.SetActive(false);
            signupButton.gameObject.SetActive(false);
            cancelButton.gameObject.SetActive(false);
        }
        else if (eventsignup3.activeSelf == true)
        {
            eventsignup3.SetActive(false);
            signupButton.gameObject.SetActive(false);
            cancelButton.gameObject.SetActive(false);
        }
    }

    public void OnClickSignUp()
    {
        if (eventsignup1.activeSelf == true)
        {
            signupCheck[0] = true;
            eventsignup1.SetActive(false);
            signupButton.gameObject.SetActive(false);
            cancelButton.gameObject.SetActive(false);
        }
        else if (eventsignup2.activeSelf == true)
        {
            signupCheck[1] = true;
            eventsignup2.SetActive(false);
            signupButton.gameObject.SetActive(false);
            cancelButton.gameObject.SetActive(false);
        }
        else if (eventsignup3.activeSelf == true)
        {
            signupCheck[2] = true;
            eventsignup3.SetActive(false);
            signupButton.gameObject.SetActive(false);
            cancelButton.gameObject.SetActive(false);
        }
    }
}
