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
        if (Panel == null && arOrigin == null && arRaycastManager == null)
            return;

        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Debug.Log("Display Touch");
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                var planetInfo = raycastHit.transform.gameObject.GetComponent<PlanetInfo>();
                if(planetInfo != null)
                {
                    Debug.Log("Something Hit " + planetInfo.header + " " + planetInfo.description);

                    if (planetInfo.header == null)
                        Debug.Log("Header is null");

                    if (planetInfo.description == null)
                        Debug.Log("description is null");

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
        Component[] childrens = Panel.GetComponentsInChildren<UnityEngine.UI.Text>();

        Debug.Log(header);
        Debug.Log(description);

        UnityEngine.UI.Text descriptionText = childrens[0].GetComponent<UnityEngine.UI.Text>();
        descriptionText.text = description;

        Component[] titleChildrens = childrens[1].GetComponentsInChildren<UnityEngine.UI.Text>();

        UnityEngine.UI.Text title = titleChildrens[0].GetComponent<UnityEngine.UI.Text>();
        title.text = header;

        if(title == null)
            Debug.Log("title is null");

        if (title == null)
            Debug.Log("descriptionText is null");

    }

    void DeactivatePanel()
    {
        Panel.SetActive(false);
    }
}
