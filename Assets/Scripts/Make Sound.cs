using System.Collections;
using System.Collections.Generic;
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
        _coroutine = StartCoroutine(ModifySound(isWoring));
    }

    public void OffSound()
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }

        isWoring = false;
        _coroutine = StartCoroutine(ModifySound(isWoring));
    }

    private IEnumerator ModifySound(bool isWorking)
    {
        if (isWoring == true)
        {
            while (_sound.volume != _maxVolume)
            {
                _sound.volume = Mathf.MoveTowards(_sound.volume, _maxVolume, _step);
                yield return null;
            }
        }
        else if(isWoring == false)
        {
            while (_sound.volume != _minVolume)
            {
                _sound.volume = Mathf.MoveTowards(_sound.volume, _minVolume, _step);
                yield return null;
            }
        }
    }

    
}