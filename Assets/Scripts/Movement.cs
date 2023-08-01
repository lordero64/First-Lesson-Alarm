using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

<<<<<<< HEAD
[RequireComponent(typeof(Animator))]

=======
>>>>>>> d664ef35d6994fd901c241acf2afadd098183efd
public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Animator _animator;
    private float _degreeTurn = 180;
    private bool _isLookingForward = true;
<<<<<<< HEAD
    private int _speedToHash = Animator.StringToHash("Speed");

=======
>>>>>>> d664ef35d6994fd901c241acf2afadd098183efd

    void Start()
    {
        _animator= GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (_isLookingForward == false)
            {
                _isLookingForward = true;
                transform.Rotate(0, _degreeTurn, 0);
            }        
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            if (_isLookingForward == true)
            {
                _isLookingForward = false;
                transform.Rotate(0, _degreeTurn, 0);
            }            
        }
        else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            Move();
        }
        else
        {
<<<<<<< HEAD
            _animator.SetFloat(_speedToHash, 0);
=======
            _animator.SetFloat("Speed", 0);
>>>>>>> d664ef35d6994fd901c241acf2afadd098183efd
        }        
    }

    private void Move()
    {
        transform.Translate(0, 0, _speed * Time.deltaTime);
<<<<<<< HEAD
        _animator.SetFloat(_speedToHash, 2);
=======
        _animator.SetFloat("Speed", 2);
>>>>>>> d664ef35d6994fd901c241acf2afadd098183efd
    }
}
