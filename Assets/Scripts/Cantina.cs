using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cantina : MonoBehaviour
{
    [Header("Cantina")]
    [SerializeField] private InteractableUnityEventWrapper CatinaWrapper;
    [SerializeField] private Animator animatorCantina;
 
 
    private void Start()
    {
        CatinaWrapper.WhenHover.AddListener(Highlight);
        CatinaWrapper.WhenUnhover.AddListener(UnHighlight);

    }
 
   
 
    private void Highlight()
    {
        animatorCantina.SetBool("On", true);
    }

    private void UnHighlight()
    {
        animatorCantina.SetBool("On", false);
    }

}
