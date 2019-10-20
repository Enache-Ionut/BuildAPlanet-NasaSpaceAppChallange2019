using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinButton : MonoBehaviour
{
    public TapToPlaceGalaxy placeObject;
    public bool rotationActive = false;

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
        rotationActive = !rotationActive;

        if(placedObject != null)
        {
            var children = GameObject.FindGameObjectsWithTag("PlanetSystem");
            foreach(var child in children)
            {
                var orbitMotion = child.GetComponent<OrbitMotion>();
                orbitMotion.orbitActive = rotationActive;
            }
        }
    }
}
