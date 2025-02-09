using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlaySound : MonoBehaviour, Interactable
{
    public AudioClip audioClip;
    public GameObject interfaceText;
    public bool raycastColliding = false;
    public void interact()
    {
        Manager.instance.playSound(audioClip);
    }

    public void onRaycastCollision()
    {
        // Debug.Log("Raycast collision with " + gameObject.name);
        raycastColliding = true;
        interfaceText.SetActive(true);
    }

    void Update()
    {
        
    }

    void LateUpdate()
    {
        // Debug.Log("LateUpdate raycastColliding: " + raycastColliding);
        interfaceText.SetActive(raycastColliding);
        raycastColliding = false;
    }

}
