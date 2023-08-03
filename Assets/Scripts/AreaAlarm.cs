using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AreaAlarm : MonoBehaviour
{
    public event UnityAction PlayerReached;
    public event UnityAction PlayerLeft;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            PlayerReached?.Invoke();
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            PlayerLeft?.Invoke();
        }
    }
}
