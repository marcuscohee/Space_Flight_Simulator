using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerBehavior : MonoBehaviour
{
    [SerializeField] private PlayableDirector _director;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player hit trigger");
        _director.Play();
        Destroy(this.gameObject);
    }
    
}
