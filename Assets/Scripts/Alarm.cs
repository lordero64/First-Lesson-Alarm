using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmLight : MonoBehaviour
{
    [SerializeField] private Light _alarmLight;
<<<<<<< HEAD
    [SerializeField] private int _intensity;

    public void LightOn()
    {
        _alarmLight.intensity = _intensity;
=======

    public void LightOn()
    {
        _alarmLight.intensity = 2;
>>>>>>> d664ef35d6994fd901c241acf2afadd098183efd
    }

    public void LightOff()
    {
        _alarmLight.intensity = 0;
    }
}
