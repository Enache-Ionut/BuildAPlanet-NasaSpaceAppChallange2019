using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPanel : MonoBehaviour
{
    public GameObject Panel;

    public void OpenPanel()
    {
        EnablePanel();
        
        if(Panel != null)
        {
            Animator animator = Panel.GetComponent<Animator>();
            if(animator != null)
            {
                bool isOpen = animator.GetBool("open");
                animator.SetBool("open", !isOpen);

            }
        }
    }

    public void EnablePanel()
    {
        Panel.SetActive(true);
    }

    
}
