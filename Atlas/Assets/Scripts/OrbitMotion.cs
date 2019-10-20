using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitMotion : MonoBehaviour
{
    public Transform orbitingObject;

    public Ellipse orbitPath;

    [Range(0f, 1f)]
    public float orbitProgress = 0f;
    public float orbitPeriod = 3f;
    public float periodDevider = 1f;

    public bool orbitActive = true;

    // Start is called before the first frame update
    void Start()
    {
        if(orbitingObject == null)
        {
            orbitActive = false;
            return;
        }

        SetOrbitingObjectPosition();

        //StartCoroutine(AnimateOrbit());
    }

    private void Update()
    {
        var tempOrbitPeriod = orbitPeriod / periodDevider;

        if (tempOrbitPeriod < 0.001f)
        {
            tempOrbitPeriod = 0.001f;
        }

        float orbitSpeed = 1f / tempOrbitPeriod;
        orbitProgress += Time.deltaTime * orbitSpeed;
        orbitProgress %= 1f;

        SetOrbitingObjectPosition();
       
    }

    void SetOrbitingObjectPosition()
    {
        Vector3 orbitPos = orbitPath.Evaluate(orbitProgress);
        if (orbitActive)
        {
            orbitingObject.localPosition = new Vector3(orbitPos.x, 0, orbitPos.y);
        }
        else
        {
            orbitingObject.localPosition = new Vector3(0, 0, orbitPath.xAxis);
        }
    }

    /*
    IEnumerator AnimateOrbit()
    {
        if(orbitPeriod < 0.1f)
        {
            orbitPeriod = 0.1f;
        }

        float orbitSpeed = 1f / orbitPeriod;

        while (orbitActive)
        {
            orbitProgress += Time.deltaTime * orbitSpeed;
            orbitProgress %= 1f;

            SetOrbitingObjectPosition();

            yield return null;
        }
    }
    */
}
