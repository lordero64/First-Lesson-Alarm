using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmLight : MonoBehaviour
{
    [SerializeField] private Light _alarmLight;

    public void LightOn()
    {
        _alarmLight.intensity = 2;
    }

    public void LightOff()
    {
        _alarmLight.intensity = 0;
    }
}
