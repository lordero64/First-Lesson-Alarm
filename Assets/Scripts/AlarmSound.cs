using System.Collections;
using UnityEngine;

public class MakeSound : MonoBehaviour
{
    [SerializeField] private AudioSource _sound;
    [SerializeField] private float _step;
    [SerializeField] private AreaAlarm _alarm;

    private Coroutine _coroutine;
    private int _maxVolume = 1;
    private int _minVolume = 0;
    private bool isWoring;

    private void OnEnable()
    {
        _alarm.PlayerReached += Work;
        _alarm.PlayerLeft += OffSound;
    }

    private void OnDisable()
    {
        _alarm.PlayerReached -= Work;
        _alarm.PlayerLeft -= OffSound;
    }

    public void Work()
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }

        isWoring = true;
        ModifySound(isWoring);
    }

    public void OffSound()
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }

        isWoring = false;
        ModifySound(isWoring);
    }

    private void ModifySound(bool isWorking)
    {
        var targetVolume = _maxVolume;

        if (isWoring == true)
        {
            targetVolume = _maxVolume;
        }
        else if (isWoring == false)
        {
            targetVolume = _minVolume;
        }

        _coroutine = StartCoroutine(ModifyVolume(targetVolume));
    }

    private IEnumerator ModifyVolume(int targetVolume)
    {
        while (_sound.volume != targetVolume)
        {
            _sound.volume = Mathf.MoveTowards(_sound.volume, targetVolume, _step);
            yield return null;
        }
    }
}