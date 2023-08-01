using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Animator _animator;
    private float _degreeTurn = 180;
    private bool _isLookingForward = true;

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
            _animator.SetFloat("Speed", 0);
        }        
    }

    private void Move()
    {
        transform.Translate(0, 0, _speed * Time.deltaTime);
        _animator.SetFloat("Speed", 2);
    }
}
