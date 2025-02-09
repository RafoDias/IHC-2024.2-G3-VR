using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface Interactable {
    public void interact();
    public void onRaycastCollision();
}

public class Interactor : MonoBehaviour
{
    public Transform interactorSource;
    public float interactRange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray continuousRay = new Ray(interactorSource.position, interactorSource.forward);
            if (Physics.Raycast(continuousRay, out RaycastHit hitInfo, interactRange)) {
                if (hitInfo.collider.gameObject.TryGetComponent(out Interactable interactObj)) {
                    interactObj.onRaycastCollision();
                }
            }
        getInteractionInput();
    }

    private void getInteractionInput() {
        if (Input.GetKeyDown(KeyCode.E)) {
            Debug.Log("Trying to interact");
            Ray r = new Ray(interactorSource.position, interactorSource.forward);
            if (Physics.Raycast(r, out RaycastHit hitInfo, interactRange)) {
                Debug.Log("hitInfo: " + hitInfo.collider.gameObject.name);
                if (hitInfo.collider.gameObject.TryGetComponent(out Interactable interactObj)) {
                    interactObj.interact();
                }
            }
        }
    }
}
