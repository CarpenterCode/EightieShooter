using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{
    [SerializeField] AudioClip[] shotClips, hitClips;
    [SerializeField] AudioSource playerSource;

    AudioClip playThis;
    int randomSound;

    public void PlayShot()
    {
        randomSound = Random.Range(0, shotClips.Length);
        playThis = shotClips[randomSound];
        playerSource.clip = playThis;
        playerSource.Play();
    }

    public void PlayHit()
    {
        randomSound = Random.Range(0, hitClips.Length);
        playThis = hitClips[randomSound];
        playerSource.clip = playThis;
        playerSource.Play();
    }
}
