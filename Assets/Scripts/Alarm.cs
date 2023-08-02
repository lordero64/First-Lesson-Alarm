using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmLight : MonoBehaviour
{
    [SerializeField] private Light _alarmLight;
    [SerializeField] private int _intensity;

    public void LightOn()
    {
        _alarmLight.intensity = _intensity;
    }

    public void LightOff()
    {
        _alarmLight.intensity = 0;
    }
}