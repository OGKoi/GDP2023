using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignUpCheck : MonoBehaviour
{
    public static SignUpCheck instance;

    public bool signedup1;
    public bool signedup2;
    public bool signedup3;

    void Awake()
    {

        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }


    public void Event1TrueFalse()
    {
        signedup1 = true;
    }

    public void Event2TrueFalse()
    {
        signedup2 = true;
    }

    public void Event3TrueFalse()
    {
        signedup3 = true;
    }
}
