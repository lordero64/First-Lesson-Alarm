using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AlarmEvent : MonoBehaviour
{
    [SerializeField] private UnityEvent _reached;
    [SerializeField] private UnityEvent _cancelled;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            _reached?.Invoke();
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            _cancelled?.Invoke();
        }
    }
}
