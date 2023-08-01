using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSound : MonoBehaviour
{
    [SerializeField] private AudioSource _sound;
    [SerializeField] private float _step;

    private Coroutine _coroutine;
    private int _maxVolume = 1;

    public void Work()
    {
        if (_coroutine!= null)
        {
            StopCoroutine(_coroutine);
        }

        _coroutine = StartCoroutine(StartSound());
    }    

    public void OffSound()
    {
        StopCoroutine(_coroutine);
        _sound.volume = 0;
    }

    private IEnumerator StartSound()
    {
        while (_sound.volume != _maxVolume)
        {
            _sound.volume = Mathf.MoveTowards(_sound.volume, _maxVolume, _step);
            yield return null;
        }
    }
}
