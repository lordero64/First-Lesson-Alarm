using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSound : MonoBehaviour
{
    [SerializeField] private AudioSource _sound;
    [SerializeField] private float _step;

    private Coroutine _coroutine;
<<<<<<< HEAD
    private int _maxVolume = 1;

    public void Work()
    {
        if (_coroutine!= null)
        {
            StopCoroutine(_coroutine);
        }

=======

    public void Work()
    {        
>>>>>>> d664ef35d6994fd901c241acf2afadd098183efd
        _coroutine = StartCoroutine(StartSound());
    }    

    public void OffSound()
    {
        StopCoroutine(_coroutine);
        _sound.volume = 0;
    }

    private IEnumerator StartSound()
    {
<<<<<<< HEAD
        while (_sound.volume != _maxVolume)
        {
            _sound.volume = Mathf.MoveTowards(_sound.volume, _maxVolume, _step);
=======
        while (_sound.volume != 1)
        {
            _sound.volume = Mathf.MoveTowards(_sound.volume, 1, _step);
>>>>>>> d664ef35d6994fd901c241acf2afadd098183efd
            yield return null;
        }
    }
}
