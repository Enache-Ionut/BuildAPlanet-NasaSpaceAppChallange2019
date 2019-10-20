using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinButton : MonoBehaviour
{
    public TapToPlaceGalaxy placeObject;

    private GameObject placedObject = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        placedObject = placeObject.GetPlacedObject();
    }

    public void ButtonPressed()
    {
        if(placedObject != null)
        {
            if (placeObject.isActiveAndEnabled)
                placedObject.SetActive(false);
            else
                placedObject.SetActive(true);
        }
    }
}
