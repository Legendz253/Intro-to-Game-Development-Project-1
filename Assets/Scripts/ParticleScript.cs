using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    public GameObject collisionParticle;
    public GameObject triggerParticle;

    //Gets executed when something enters the trigger, or when this object enters a trigger
    private void OnTriggerEnter(Collider other)
    {
        if (triggerParticle != null)
        {
            //The triggerParticle will spawn at the location of this object with the same rotation as it.
            Instantiate(triggerParticle, this.transform.position, this.transform.rotation);
        }
    }
    //Executed when something colides with this object.
    private void OnCollisionEnter(Collision collision)
    {
        if (triggerParticle != null)
        {
            //The collisionParticle will spawn at the location of this ___ with the same rotation as it.
            Instantiate(collisionParticle, collision.contacts[0].point, this.transform.rotation);
        }
    }
}
