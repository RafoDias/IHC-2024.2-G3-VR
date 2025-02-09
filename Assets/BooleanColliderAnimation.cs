using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BooleanColliderAnimation : MonoBehaviour
{
    [SerializeField] private GameObject gameObjctToBeAnimated;
    [SerializeField] private Animator anim;
    [SerializeField] private string triggerName;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered");
        if (other.gameObject.tag == "Player")
        {
            anim.SetBool(triggerName, true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Staying");
        if (other.gameObject.tag == "Player")
        {
            anim.SetBool(triggerName, true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited");
        if (other.gameObject.tag == "Player")
        {
            anim.SetBool(triggerName, false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        Debug.Log(gameObjctToBeAnimated);


        if (anim == null)
        {
            anim = gameObjctToBeAnimated.GetComponent<Animator>();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
