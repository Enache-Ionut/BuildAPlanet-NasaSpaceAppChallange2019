using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideSpeed : MonoBehaviour
{
    public TapToPlaceGalaxy placeObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnValueChanged(int value)
    {
        var children = GameObject.FindGameObjectsWithTag("PlanetSystem");
        foreach (var child in children)
        {
            var orbitMotion = child.GetComponent<OrbitMotion>();
            orbitMotion.periodDevider = value / 10;
        }

        children = GameObject.FindGameObjectsWithTag("MoonSystem");
        foreach (var child in children)
        {
            var orbitMotion = child.GetComponent<OrbitMotion>();
            orbitMotion.periodDevider = value / 10;
        }

    }
}
