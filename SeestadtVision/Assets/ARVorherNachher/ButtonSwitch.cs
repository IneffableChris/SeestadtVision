using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSwitch : MonoBehaviour
{


    public GameObject vorher, nachher;
    public bool vorherbild = false;
    public bool nachherbild = true;


    public void ChangeImage()
    {
        if(vorherbild == false)
        {
            vorher.SetActive(true);
            nachher.SetActive(false);

        } if (nachherbild == false) { 
            vorher.SetActive(false);
            nachher.SetActive(true);
        }
    }
}
