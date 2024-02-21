using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PortalUpdateManager : MonoBehaviour
{
    public CinemachineVirtualCamera Vcam_1, VCam_2;
    public List<GameObject> Weapons = new();
    
    private int activeIndex;

    private void OnEnable()
    {
        EventsManager.OnAxePortal += AxeEnabled;
        EventsManager.OnKnifePortal += KnifeEnabled;
        EventsManager.OnPlusOnePortal += PlusOnePlayer;
    }

    private void OnDisable()
    {
        EventsManager.OnAxePortal -= AxeEnabled;
        EventsManager.OnKnifePortal -= KnifeEnabled;
        EventsManager.OnPlusOnePortal -= PlusOnePlayer;
    }


    private void PlusOnePlayer()
    {
        throw new System.NotImplementedException();
    }

    private void KnifeEnabled()
    {
       
    }

    private void AxeEnabled()
    {
        ToggleObject(0);
    }

    void ToggleObject(int index)
    {
        for (int i = 0; i < Weapons.Count; i++)
        {
            Weapons[i].gameObject.SetActive(i == index && !Weapons[i].activeSelf);
        }
    }
}
