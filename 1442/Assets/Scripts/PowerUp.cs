using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public bool iceBoost;
    public bool fireBoost;
    public float speed = .5f;

    public AudioClip despawnSound; // Drag and drop your sound clip in Unity Inspector
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Get the AudioSource component
    }

    void Update()
    {
        transform.Translate(new Vector3(0f, -0.5f, 0f) * Time.deltaTime * speed);
    }

    void OnDestroy()
    {
        if (despawnSound != null)
        {
            audioSource.PlayOneShot(despawnSound); // Play the sound when the object is destroyed
        }
    }
}
