using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioClip[] explosionClips, shotClips, hitClips;
    int randomSound;
    AudioSource thisSource;
    AudioClip playThis;

    private void Start()
    {
        thisSource = this.gameObject.GetComponent<AudioSource>();
    }

    public void PlayExplosion()
    {
        randomSound = Random.Range(0, explosionClips.Length);
        playThis = explosionClips[randomSound];
        thisSource.clip = playThis;
        thisSource.Play();
    }

    public void PlayShot()
    {
        randomSound = Random.Range(0, shotClips.Length);
        playThis = shotClips[randomSound];
        thisSource.clip = playThis;
        thisSource.Play();
    }

    public void PlayHit()
    {
        randomSound = Random.Range(0, hitClips.Length);
        playThis = hitClips[randomSound];
        thisSource.clip = playThis;
        thisSource.Play();
    }
}
