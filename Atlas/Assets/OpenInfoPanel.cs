using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenInfoPanel : MonoBehaviour
{
    public GameObject Panel;

    public void EnablePanel()
    {
        Panel.SetActive(true);
    }

    Ray ray;
    RaycastHit hit;

    void OnMouseDown()
    { 
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            string getTextInfoPlanet = hit.collider.gameObject.GetComponent<Text>().ToString();
            switch (hit.collider.tag)
            {
                case "Mercury":
                    EnablePanel();

                    if (Panel != null)
                    {
                        Animator animator = Panel.GetComponent<Animator>();
                        Panel.GetComponent<Text>().text = getTextInfoPlanet;
                        if (animator != null)
                        {
                            bool isOpen = animator.GetBool("open");
                            animator.SetBool("open", !isOpen);

                        }
                    }

                    break;
                case "Venus":
                    EnablePanel();

                    if (Panel != null)
                    {
                        Animator animator = Panel.GetComponent<Animator>();
                        Panel.GetComponent<Text>().text = getTextInfoPlanet;
                        if (animator != null)
                        {
                            bool isOpen = animator.GetBool("open");
                            animator.SetBool("open", !isOpen);

                        }
                    }
                    break;
                case "Earth":
                    EnablePanel();

                    if (Panel != null)
                    {
                        Animator animator = Panel.GetComponent<Animator>();
                        Panel.GetComponent<Text>().text = getTextInfoPlanet;
                        if (animator != null)
                        {
                            bool isOpen = animator.GetBool("open");
                            animator.SetBool("open", !isOpen);

                        }
                    }
                    break;
                case "Mars":
                    EnablePanel();

                    if (Panel != null)
                    {
                        Animator animator = Panel.GetComponent<Animator>();
                        Panel.GetComponent<Text>().text = getTextInfoPlanet;
                        if (animator != null)
                        {
                            bool isOpen = animator.GetBool("open");
                            animator.SetBool("open", !isOpen);

                        }
                    }
                    break;
                case "Jupiter":
                    EnablePanel();

                    if (Panel != null)
                    {
                        Animator animator = Panel.GetComponent<Animator>();
                        Panel.GetComponent<Text>().text = getTextInfoPlanet;
                        if (animator != null)
                        {
                            bool isOpen = animator.GetBool("open");
                            animator.SetBool("open", !isOpen);

                        }
                    }
                    break;
                case "Saturn":
                    EnablePanel();

                    if (Panel != null)
                    {
                        Animator animator = Panel.GetComponent<Animator>();
                        Panel.GetComponent<Text>().text = getTextInfoPlanet;
                        if (animator != null)
                        {
                            bool isOpen = animator.GetBool("open");
                            animator.SetBool("open", !isOpen);

                        }
                    }
                    break;
                case "Uranus":
                    EnablePanel();

                    if (Panel != null)
                    {
                        Animator animator = Panel.GetComponent<Animator>();
                        Panel.GetComponent<Text>().text = getTextInfoPlanet;
                        if (animator != null)
                        {
                            bool isOpen = animator.GetBool("open");
                            animator.SetBool("open", !isOpen);

                        }
                    }
                    break;
                case "Neptune":
                    EnablePanel();

                    if (Panel != null)
                    {
                        Animator animator = Panel.GetComponent<Animator>();
                        Panel.GetComponent<Text>().text = getTextInfoPlanet;
                        if (animator != null)
                        {
                            bool isOpen = animator.GetBool("open");
                            animator.SetBool("open", !isOpen);

                        }
                    }
                    break;
                case "Pluto":
                    EnablePanel();

                    if (Panel != null)
                    {
                        Animator animator = Panel.GetComponent<Animator>();
                        Panel.GetComponent<Text>().text = getTextInfoPlanet;
                        if (animator != null)
                        {
                            bool isOpen = animator.GetBool("open");
                            animator.SetBool("open", !isOpen);

                        }
                    }
                    break;
                default:
                    break;

            }
        }
    }
}

