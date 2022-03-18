using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] private List <AudioClip> gameMusic;
    [SerializeField] private AudioSource audioSorce;

    private void Start()
    {
        audioSorce.PlayOneShot(gameMusic[Random.Range(0, 3)]);
    }
}
