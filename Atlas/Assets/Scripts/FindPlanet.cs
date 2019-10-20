using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.Experimental.XR;
using System;
using UnityEngine.XR.ARSubsystems;

public class FindPlanet : MonoBehaviour
{
    private ARSessionOrigin arOrigin;
    private ARRaycastManager arRaycastManager;

    public GameObject Panel;

    // Start is called before the first frame update
    void Start()
    {
        arOrigin = FindObjectOfType<ARSessionOrigin>();
        arRaycastManager = FindObjectOfType<ARRaycastManager>();
        Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Debug.Log("Display Touch");
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                Debug.Log("Something Hit");

                var planetInfo = raycastHit.transform.gameObject.GetComponent<PlanetInfo>();
                if(planetInfo != null)
                {
                    ActivatePanel(planetInfo.header, planetInfo.description);
                }
            }
            else
            {
                DeactivatePanel();
            }
        }
    }

    void ActivatePanel(string header, string description)
    {
        Panel.SetActive(true);
        Transform[] ts = gameObject.GetComponentsInChildren<Transform>();

        Debug.Log(header);
        Debug.Log(description);

        ts[0].gameObject.GetComponent<UnityEngine.UI.Text>().text = header;
        ts[1].gameObject.GetComponent<UnityEngine.UI.Text>().text = description;
    }

    void DeactivatePanel()
    {
        Panel.SetActive(false);
    }
}
