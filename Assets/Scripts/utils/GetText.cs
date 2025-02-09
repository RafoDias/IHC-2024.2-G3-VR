using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;

public class GetText : MonoBehaviour
{
    private TextMeshPro tmp;
    public GameObject goNameRef;
    private int poemIndex;
    private PlaySound parentPlaySound;
    // Start is called before the first frame update
    void Start()
    {
        parentPlaySound = GetComponentInParent<PlaySound>();
        tmp = GetComponent<TextMeshPro>();
        poemIndex = Int32.Parse(Regex.Match(goNameRef.name, @"\d+").Value);
        tmp.text = Manager.poemTexts[poemIndex];
        parentPlaySound.audioClip = Manager.instance.audioClips[poemIndex];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
