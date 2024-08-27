using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class TeleportActionHandler : MonoBehaviour
{
    public InputActionReference inputActionReference;

    public UnityEvent OnShow;
    public UnityEvent OnHide;

    private void OnEnable()
    {
        inputActionReference.action.performed += OnPerformed;
        inputActionReference.action.canceled += OnCanceled;
    }

    private void OnDisable()
    {
        inputActionReference.action.performed -= OnPerformed;
        inputActionReference.action.canceled -= OnCanceled;
    }

    public void OnPerformed(InputAction.CallbackContext context)
    {        
        StartCoroutine(DelayCall(OnShow));
    }

    public void OnCanceled(InputAction.CallbackContext context)
    {
        StartCoroutine(DelayCall(OnHide));
    }

    IEnumerator DelayCall(UnityEvent e)
    {
        yield return null;
        e?.Invoke();
    }
}
