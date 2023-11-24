using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerScript : MonoBehaviour
{
    public bool PlayTimeline = false;
    public PlayableDirector TriggerTimeline;

    private void OnTriggerEnter(Collider other)
    {
        TriggerTimeline.Play();
    }
}
