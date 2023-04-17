using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleFireplace : MonoBehaviour
{
    [SerializeField] private GameObject fireplace;
    private bool isFireplaceOn = false;

    public void ToggleFireplaceFire() 
    {
        if (!isFireplaceOn) 
        {
            fireplace.SetActive(true);
            isFireplaceOn = !isFireplaceOn;
        } else {
            fireplace.SetActive(false);
            isFireplaceOn = !isFireplaceOn;
        }
    }
}
