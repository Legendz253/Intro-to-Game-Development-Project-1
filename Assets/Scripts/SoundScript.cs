using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    //The sound when an object enters this trigger.
    public AudioClip triggerSound;
    //The audio source that will play that sound
    public AudioSource source;

    private void OnTriggerEnter(Collider other)
    {
        //Tells the source to play sound triggerSound one time.
        source.PlayOneShot(triggerSound);
    }
}
