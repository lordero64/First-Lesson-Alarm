using UnityEngine;

public class AlarmLight : MonoBehaviour
{
    [SerializeField] private Light _alarmLight;
    [SerializeField] private int _intensity;
    [SerializeField] private AreaAlarm _alarm;

    public void LightOn()
    {
        _alarmLight.intensity = _intensity;
    }

    public void LightOff()
    {
        _alarmLight.intensity = 0;
    }

    private void OnEnable()
    {
        _alarm.PlayerReached += LightOn;
        _alarm.PlayerLeft += LightOff;     
    }

    private void OnDisable()
    {
        _alarm.PlayerReached -= LightOn;
        _alarm.PlayerLeft -= LightOff;     
    }
}
