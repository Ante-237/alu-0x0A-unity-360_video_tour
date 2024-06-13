using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourManager : MonoBehaviour
{
    [Header("Event Triggers")]
    [SerializeField] private InteractableUnityEventWrapper LivingRoom;
    [SerializeField] private InteractableUnityEventWrapper Cantina;
    [SerializeField] private InteractableUnityEventWrapper Cube;


    [Header("Objs")]
    [SerializeField] private GameObject CantinaObj;
    [SerializeField] private GameObject CantinaUI;
    [SerializeField] private GameObject LivingRoomObj;
    [SerializeField] private GameObject LivingRoomUI;
    [SerializeField] private GameObject CubeObj;
    [SerializeField] private GameObject CubeUI;


    private void Start()
    {
        LivingRoom.WhenSelect.AddListener(LivingRoomSelected);
        Cantina.WhenSelect.AddListener(CantinaSelected);
        Cube.WhenSelect.AddListener(CubeSelected);
    }

    private void FadeOutEffect()
    {

    }

    private void FadeInEffect()
    {

    }

    public void LivingRoomSelected()
    {
        LivingRoomObj.SetActive(true);
        LivingRoomUI.SetActive(true);
        CantinaObj.SetActive(false);
        CantinaUI.SetActive(false);
        CubeObj.SetActive(false);
        CubeUI.SetActive(false);
    }

    public void CantinaSelected()
    {
        LivingRoomObj.SetActive(false);
        LivingRoomUI.SetActive(false);
        CantinaObj.SetActive(true);
        CantinaUI.SetActive(true);
        CubeObj.SetActive(false);
        CubeUI.SetActive(false);
    }

    public void CubeSelected()
    {

        LivingRoomObj.SetActive(false);
        LivingRoomUI.SetActive(false);
        CantinaObj.SetActive(false);
        CantinaUI.SetActive(false);
        CubeObj.SetActive(true);
        CubeUI.SetActive(true);
    }
}
