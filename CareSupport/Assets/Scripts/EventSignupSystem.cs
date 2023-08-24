using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventSignupSystem : MonoBehaviour
{
    public Button preview1;
    public Button preview2;
    public Button preview3;

    public GameObject eventsignup1;
    public GameObject eventsignup2;
    public GameObject eventsignup3;

    public Button signupButton;
    public Button cancelButton;

    public SignUpCheck signupCheck;

    public Image eventsignupPopup;

    public void Start()
    {
        
        signupCheck = FindObjectOfType<SignUpCheck>();

    }
    public void OnClickEvent1()
    {
        
            eventsignup1.SetActive(true);
            signupButton.gameObject.SetActive(true);
            cancelButton.gameObject.SetActive(true);
    }

    public void OnClickEvent2()
    {

        eventsignup2.SetActive(true);
        signupButton.gameObject.SetActive(true);
        cancelButton.gameObject.SetActive(true);
    }
    public void OnClickEvent3()
    {

        eventsignup3.SetActive(true);
        signupButton.gameObject.SetActive(true);
        cancelButton.gameObject.SetActive(true);
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
            signupCheck.Event1TrueFalse();
            eventsignupPopup.gameObject.SetActive(true);
            Invoke("eventsignupPopupCoroutine",0.5f);
            eventsignup1.SetActive(false);
            signupButton.gameObject.SetActive(false);
            cancelButton.gameObject.SetActive(false);
        }
        else if (eventsignup2.activeSelf == true)
        {
            signupCheck.Event2TrueFalse();
            eventsignupPopup.gameObject.SetActive(true);
            Invoke("eventsignupPopupCoroutine", 0.5f);
            eventsignup2.SetActive(false);
            signupButton.gameObject.SetActive(false);
            cancelButton.gameObject.SetActive(false);
        }
        else if (eventsignup3.activeSelf == true)
        {
            signupCheck.Event3TrueFalse();
            eventsignupPopup.gameObject.SetActive(true);
            Invoke("eventsignupPopupCoroutine", 0.5f);
            eventsignup3.SetActive(false);
            signupButton.gameObject.SetActive(false);
            cancelButton.gameObject.SetActive(false);
        }
    }

    public void eventsignupPopupCoroutine()
    {
        eventsignupPopup.gameObject.SetActive(false);
    }
}
