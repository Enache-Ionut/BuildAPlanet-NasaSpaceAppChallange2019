using UnityEngine;
using System.Collections;

// add this to a Particle System which has a parent game object, to see how each scaling mode works
public class ParticleSystemScaling : MonoBehaviour
{
    ParticleSystem _ps;
    public float sizeModifier = 1.0f;

    void Awake()
    {
        _ps = GetComponent<ParticleSystem>();
        //For each property you want to scale, just multiply it by the size modifier.
        _ps.startSize *= sizeModifier;
    }
}