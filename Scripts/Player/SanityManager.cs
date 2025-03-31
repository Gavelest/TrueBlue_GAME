using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SanityManager : MonoBehaviour
{

    Slider sanitySlider; 
    public int fullSanity;
    public int difficulty;
    
    void Start()
    {

        sanitySlider = GetComponent<Slider>();
        sanitySlider.maxValue = fullSanity;
        sanitySlider.value = fullSanity; 

    }

    //IEnumerator LoseSanity()
    //{



   // }


}
