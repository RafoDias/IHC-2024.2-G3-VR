using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;

public class GetPoemData : MonoBehaviour
{
    public GameObject tmpGameObject;
    public GameObject boardGameObject;
    public GameObject textAreaGameObject;
    private TextMeshPro tmp;
    private PlaySound parentPlaySound;
    private int poemIndex;
    private MeshRenderer portraitMeshRenderer;

    void Start()
    {
        parentPlaySound = textAreaGameObject.GetComponentInParent<PlaySound>();
        tmp = tmpGameObject.GetComponent<TextMeshPro>();
        portraitMeshRenderer = boardGameObject.GetComponent<MeshRenderer>();

        poemIndex = Int32.Parse(Regex.Match(this.name, @"\d+").Value);

        tmp.text = Manager.poemTexts[poemIndex];
        parentPlaySound.audioClip = Manager.instance.audioClips[poemIndex];
        portraitMeshRenderer.material = Manager.instance.materials[poemIndex];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
