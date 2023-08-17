using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuidesSystem : MonoBehaviour
{
    public GameObject guide1;

    public void OnClickGuide1()
    {
        guide1.SetActive(true);
    }
}
