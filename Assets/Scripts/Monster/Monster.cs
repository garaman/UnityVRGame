using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class Monster : MonoBehaviour
{
    public float destroyDelay = 1f;   

    public UnityEvent onCreated;
    public UnityEvent onDestroy;

    private bool isDestroyed = false;


    void Start()
    {
        onCreated?.Invoke();
    }

    public void Destroy()
    {
        if (isDestroyed) { return; }
        isDestroyed = true;
        
        Destroy(gameObject, destroyDelay);

        onDestroy?.Invoke();
    }


}
