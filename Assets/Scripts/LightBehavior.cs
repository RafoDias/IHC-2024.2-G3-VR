using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBehavior : MonoBehaviour
{
    // Objeto para onde a luz vai apontar
    [SerializeField] private GameObject directionReferenceObject;
    [SerializeField] private Transform selfTransform;
    // Start is called before the first frame update
    void Start()
    {
        if (selfTransform == null)
        {
            selfTransform = transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        FaceDirectionReferenceObject();
    }

    private void FixedUpdate()
    {
        
    }

    private void FaceDirectionReferenceObject() {
        // Se o objeto de referência existir
        if (directionReferenceObject != null)
        {
            // Atualiza a direção da luz
            selfTransform.LookAt(directionReferenceObject.transform);
        }
    }
}
