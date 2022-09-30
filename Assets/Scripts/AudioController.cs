using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource background;
    public AudioSource normal;
    private bool status = false;

    // Start is called before the first frame update
    void Start()
    {
        background.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (!background.isPlaying && status == false)
        {
            status = true;
            normal.Play();
            normal.loop = true;
        }
    }
}
