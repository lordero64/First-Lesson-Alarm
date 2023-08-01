using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSound : MonoBehaviour
{
    [SerializeField] private AudioSource _sound;
    [SerializeField] private float _step;

    private Coroutine _coroutine;

    public void Work()
    {        
        _coroutine = StartCoroutine(StartSound());
    }    

    public void OffSound()
    {
        StopCoroutine(_coroutine);
        _sound.volume = 0;
    }

    private IEnumerator StartSound()
    {
        while (_sound.volume != 1)
        {
            _sound.volume = Mathf.MoveTowards(_sound.volume, 1, _step);
            yield return null;
        }
    }
}
