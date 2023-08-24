using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomepageSystem : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Event1;
    public GameObject Event2;
    public GameObject Event3;

    public GameObject placeholder1;
    public GameObject placeholder2;
    public GameObject placeholder3;

    public SignUpCheck signUpCheck;

    public void Start()
    {
        signUpCheck = FindObjectOfType<SignUpCheck>();
        
    }

    void Update()
    {

        bool signedup1 = signUpCheck.signedup1;
        bool signedup2 = signUpCheck.signedup2;
        bool signedup3 = signUpCheck.signedup3;

        if (signedup1 == true)
        {
            if (((Event2.transform.position != placeholder1.transform.position) || (Event2.activeSelf != true)) && ((Event3.transform.position != placeholder1.transform.position) || (Event3.activeSelf != true)))
            {
                Event1.SetActive (true);
                Event1.transform.position = placeholder1.transform.position;
            }
            else if (((Event2.transform.position != placeholder2.transform.position) || (Event2.activeSelf != true)) && ((Event3.transform.position != placeholder2.transform.position) || (Event3.activeSelf != true)))
            {
                Event1.SetActive(true);
                Event1.transform.position = placeholder2.transform.position;
            }
            else if (((Event2.transform.position != placeholder3.transform.position) || (Event2.activeSelf != true)) && ((Event3.transform.position != placeholder3.transform.position) || (Event3.activeSelf != true)))
            {
                Event1.SetActive(true);
                Event1.transform.position = placeholder3.transform.position;
            }
        }
        
        if (signedup2 == true)
        {
            if (((Event1.transform.position != placeholder1.transform.position) || (Event1.activeSelf != true)) && ((Event3.transform.position != placeholder1.transform.position) || (Event3.activeSelf != true)))
            {
                Event2.transform.position = placeholder1.transform.position;
                Event2.SetActive(true);
            }
            else if (((Event1.transform.position != placeholder2.transform.position) || (Event1.activeSelf != true)) && ((Event3.transform.position != placeholder2.transform.position) || (Event3.activeSelf != true)))
            {
                Event2.SetActive(true);
                Event2.transform.position = placeholder2.transform.position;
            }
            else if (((Event1.transform.position != placeholder3.transform.position) || (Event1.activeSelf != true)) && ((Event3.transform.position != placeholder3.transform.position) || (Event3.activeSelf != true)))
            {
                Event2.SetActive(true);
                Event2.transform.position = placeholder3.transform.position;
            }
        }
        
        if (signedup3 == true)
        {
            if (((Event1.transform.position != placeholder1.transform.position) || (Event1.activeSelf != true)) && ((Event2.transform.position != placeholder1.transform.position) || (Event2.activeSelf != true)))
            {
                Event3.SetActive(true);
                Event3.transform.position = placeholder1.transform.position;
            }
            else if (((Event1.transform.position != placeholder2.transform.position) || (Event1.activeSelf != true)) && ((Event2.transform.position != placeholder2.transform.position) || (Event2.activeSelf != true)))
            {
                Event3.SetActive(true);
                Event3.transform.position = placeholder2.transform.position;             
            }
            else if (((Event1.transform.position != placeholder3.transform.position) || (Event1.activeSelf != true)) && ((Event2.transform.position != placeholder3.transform.position) || (Event2.activeSelf != true)))
            {
                Event3.SetActive(true);
                Event3.transform.position = placeholder3.transform.position;
            }
        }
    
    }
 
}
