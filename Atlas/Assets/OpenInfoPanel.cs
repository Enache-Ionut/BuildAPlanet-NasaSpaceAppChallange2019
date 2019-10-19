using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenInfoPanel : MonoBehaviour
{
    public GameObject Panel;

    void EnablePanel(bool param)
    {
        Panel.SetActive(true);
    }

    Ray ray;
    RaycastHit hit;

    void OnMouseDown()
    {
        EnablePanel(false);
        if (Panel.activeSelf)
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                string getTextInfoPlanet = hit.collider.gameObject.GetComponent<Text>().text;

                Component[] panelTextList;
                panelTextList = Panel.GetComponentsInChildren<Text>();
                EnablePanel(false);

                switch (hit.collider.tag)
                {
                    case "Mercury":
                        EnablePanel(true);

                        if (Panel != null)
                        {
                            Animator animator = Panel.GetComponent<Animator>();
                            panelTextList[0].GetComponent<Text>().text = "Mercury";
                            panelTextList[1].GetComponent<Text>().text = getTextInfoPlanet;
                            if (animator != null)
                            {
                                bool isOpen = animator.GetBool("open");
                                animator.SetBool("open", !isOpen);

                            }
                        }

                        break;
                    case "Venus":
                        EnablePanel(true);

                        if (Panel != null)
                        {
                            Animator animator = Panel.GetComponent<Animator>();
                            panelTextList[0].GetComponent<Text>().text = "Venus";
                            panelTextList[1].GetComponent<Text>().text = getTextInfoPlanet;
                            if (animator != null)
                            {
                                bool isOpen = animator.GetBool("open");
                                animator.SetBool("open", !isOpen);

                            }
                        }
                        break;
                    case "Earth":
                        EnablePanel(true);

                        if (Panel != null)
                        {
                            Animator animator = Panel.GetComponent<Animator>();
                            panelTextList[0].GetComponent<Text>().text = "Earth";
                            panelTextList[1].GetComponent<Text>().text = getTextInfoPlanet;
                            if (animator != null)
                            {
                                bool isOpen = animator.GetBool("open");
                                animator.SetBool("open", !isOpen);

                            }
                        }
                        break;
                    case "Mars":
                        EnablePanel(true);

                        if (Panel != null)
                        {
                            Animator animator = Panel.GetComponent<Animator>();
                            panelTextList[0].GetComponent<Text>().text = "Mars";
                            panelTextList[1].GetComponent<Text>().text = getTextInfoPlanet;
                            if (animator != null)
                            {
                                bool isOpen = animator.GetBool("open");
                                animator.SetBool("open", !isOpen);

                            }
                        }
                        break;
                    case "Jupiter":
                        EnablePanel(true);

                        if (Panel != null)
                        {
                            Animator animator = Panel.GetComponent<Animator>();
                            panelTextList[0].GetComponent<Text>().text = "Jupiter";
                            panelTextList[1].GetComponent<Text>().text = getTextInfoPlanet;
                            if (animator != null)
                            {
                                bool isOpen = animator.GetBool("open");
                                animator.SetBool("open", !isOpen);

                            }
                        }
                        break;
                    case "Saturn":
                        EnablePanel(true);

                        if (Panel != null)
                        {
                            Animator animator = Panel.GetComponent<Animator>();
                            panelTextList[0].GetComponent<Text>().text = "Saturn";
                            panelTextList[1].GetComponent<Text>().text = getTextInfoPlanet;
                            if (animator != null)
                            {
                                bool isOpen = animator.GetBool("open");
                                animator.SetBool("open", !isOpen);

                            }
                        }
                        break;
                    case "Uranus":
                        EnablePanel(true);

                        if (Panel != null)
                        {
                            Animator animator = Panel.GetComponent<Animator>();
                            panelTextList[0].GetComponent<Text>().text = "Uranus";
                            panelTextList[1].GetComponent<Text>().text = getTextInfoPlanet;
                            if (animator != null)
                            {
                                bool isOpen = animator.GetBool("open");
                                animator.SetBool("open", !isOpen);

                            }
                        }
                        break;
                    case "Neptune":
                        EnablePanel(true);

                        if (Panel != null)
                        {
                            Animator animator = Panel.GetComponent<Animator>();
                            panelTextList[0].GetComponent<Text>().text = "Neptune";
                            panelTextList[1].GetComponent<Text>().text = getTextInfoPlanet;
                            if (animator != null)
                            {
                                bool isOpen = animator.GetBool("open");
                                animator.SetBool("open", !isOpen);

                            }
                        }
                        break;
                    case "Pluto":
                        EnablePanel(true);

                        if (Panel != null)
                        {
                            Animator animator = Panel.GetComponent<Animator>();
                            panelTextList[0].GetComponent<Text>().text = "Pluto";
                            panelTextList[1].GetComponent<Text>().text = getTextInfoPlanet;

                            if (animator != null)
                            {
                                bool isOpen = animator.GetBool("open");
                                animator.SetBool("open", !isOpen);

                            }
                        }
                        break;
                    default:
                        EnablePanel(false);
                        break;

                }
            }
        }
        
    }
}

