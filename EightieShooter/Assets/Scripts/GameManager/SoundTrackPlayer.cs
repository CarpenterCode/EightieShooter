using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrackPlayer : MonoBehaviour
{
    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    private void Update()
    {
        this.gameObject.transform.position = Camera.main.transform.position;
    }
}
