using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager instance {get; private set; }
    private AudioSource audioSource;

    void Awake() {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        } else
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void playSound(AudioClip audioClip) {
        audioSource.PlayOneShot(audioClip);
    }

    public AudioSource getAudioSource() {
        return audioSource;
    }

    public static String[] poemTexts = {
        "Neste pôr do sol,\nEnclausurado e triste,\nA vida diz sim.",
        "Num flash de luz\nExplode a flor no concreto.\nPrisão de desejos.",
        "Um nado vermelho,\nO suicídio de pétalas.\nInvasão do nada.",
        "A mãe se esvai...\nEstilhaços de memória,\nUm corte profundo.",
        "Foi nesta mantilha\nQue a dor foi reclamada.\nJoelhos são lastros.",
        "A flor pão dos pobres\nPosta em vaso, ora-pro-nóbis.\nCéu de tangerina.",
        "Bule azul de ágata\nEm um mundo flutuante.\nA mãe serve o chá.",
        "O sol evapora\nEm uma tarde sem fim.\nSertão é miragem...",
        "Na caixa do ar\nAlastra-se o espaço.\nVertical-cidade.",
        "Era um Deus menino\nRegendo o chão da manhã.\nMatulão de fé.",
        "O espelho pranteia\nNossa solidão de eras.\nBritas testemunham.",
        "Vejo-me no vidro,\nVoyeur de um século parco.\nFechado o balanço.",
        "Há morte corrente\nNa ferrugem que assombra.\nPranto a cadeado.",
        "Deus espia ao longe\nUma perversão moderna.\nO amor ofusca.",
        "Partido e sem alma\nÉ o losango do tempo.\nFendas ao vento.",
        "O lar se desfaz\nE a vida é céu adverso.\nO Duchamp contempla.",
        "Estações suspensas\nDentro de um fio quebrado.\nPalavras não ditas.",
        "Espelho difuso,\nInsanidade perfeita.\nAs flores do mal.",
        "A árvore é parte\nDo escritório suspenso.\nLabor ambulante.",
        "Bicicletas voam\nNa cidade que não vê.\nDor no app.\n",
    };

    [SerializeField]
    public AudioClip[] audioClips;
    [SerializeField]
    public Material[] materials;
    
}
