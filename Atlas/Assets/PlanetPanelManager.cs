using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetPanelManager : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject planet;
    public GameObject planetSizePanel;
    public GameObject createPlanetPanel;
    public GameObject moonPanel;
    public GameObject planetChemistry;

    // Start is called before the first frame update

    public void ActivatePlanetSizePanel()
    {
        mainPanel.SetActive(false);
        planet.SetActive(true);
        planetSizePanel.SetActive(true);
    }


    public void ActivateMoonPanel()
    {
        planetSizePanel.SetActive(false);
        moonPanel.SetActive(true);
    }

    public void ActivatePlanetChemistry()
    {
        moonPanel.SetActive(false);
        planetChemistry.SetActive(true);
    }

    public void ActivateCreatePlanet()
    {
        planetChemistry.SetActive(false);
        createPlanetPanel.SetActive(true);
    }

}
