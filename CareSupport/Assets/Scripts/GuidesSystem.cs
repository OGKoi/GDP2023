using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuidesSystem : MonoBehaviour
{
    public GameObject guide1;
    public Image page1;
    public Image page2;
    public Image page3;
    
    public void OnClickGuide1()
    {
        guide1.SetActive(true);
    } 
    
    public void Forward()
    {
        page1.gameObject.SetActive(false);
        page2.gameObject.SetActive(true);
    }

    public void Backward()
    {
        
    }
}
