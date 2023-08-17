using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomepageSystem : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Event1;
    public GameObject Event2;
    public GameObject Event3;

    public Vector3 position1 = new Vector3 (0, 85, 0);
    public Vector3 position2 = new Vector3(0, 200, 0);
    public Vector3 position3 = new Vector3(0, 400, 0);
    
    public bool pos1open = true;
    public bool pos2open = true;
    public bool pos3open = true;
    
    public bool[] signupcheckDisplay = EventSignupSystem.signupCheck;

    void Update()
    {
        if (signupcheckDisplay[0] == true)
        {
            if (pos1open == true)
            {
                Instantiate(Event1, position1, Quaternion.identity);
                pos1open = false;
            }
            else if (pos2open == true)
            {
                Instantiate(Event1, position2, Quaternion.identity);
                pos2open = false;
            }
            else if (pos3open == true)
            {
                Instantiate(Event1, position3, Quaternion.identity);
                pos3open = false;
            }
        }
        else if (signupcheckDisplay[1] == true)
        {
            if (pos1open == true)
            {
                Instantiate(Event2, position1, Quaternion.identity);
                pos1open = false;
            }
            else if (pos2open == true)
            {
                Instantiate(Event2, position2, Quaternion.identity);
                pos2open = false;
            }
            else if (pos3open == true)
            {
                Instantiate(Event2, position3, Quaternion.identity);
                pos3open = false;
            }
        }
        else if (signupcheckDisplay[2] == true)
        {
            if (pos1open == true)
            {
                Instantiate(Event3, position1, Quaternion.identity);
                pos1open = false;
            }
            else if (pos2open == true)
            {
                Instantiate(Event3, position2, Quaternion.identity);
                pos2open = false;
            }
            else if (pos3open == true)
            {
                Instantiate(Event3, position3, Quaternion.identity);
                pos3open = false;
            }
        }
    }
}
