using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shapes : MonoBehaviour
{
    [SerializeField]
    private List<AudioClip> noises;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        audioSource.clip = noises[Random.Range(0, noises.Count)];
        audioSource.Play();
    }

    private void Update()
    {
        // POLYMORPHISM
        Move();
    }

    // ABSTRACTION
    protected abstract void Move();
}