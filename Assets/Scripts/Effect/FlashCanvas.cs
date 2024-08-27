using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashCanvas : MonoBehaviour
{
    public float duration = 0.05f;

    private Canvas target;

    private void Awake()
    {
        target = GetComponent<Canvas>();
    }

    public void Call()
    {
        StopAllCoroutines();
        StartCoroutine(Process());
    }

    IEnumerator Process()
    {
        target.enabled = true;

        yield return new WaitForSeconds(duration);

        target.enabled = false;
    }
}
