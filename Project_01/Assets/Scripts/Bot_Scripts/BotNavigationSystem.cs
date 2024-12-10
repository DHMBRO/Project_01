using System.Collections.Generic;
using UnityEngine;

public class BotNavigationSystem : MonoBehaviour, IImplementation
{
    [SerializeField] private List<Transform> _transformPoints = new List<Transform>();
    [SerializeField] private int _nextIndexOfTarget = 0;

    [SerializeField] private Vector3 _currentDirection = Vector3.zero;
    
    [SerializeField] private float _minDistanceToArrive = 0.1f;
    [SerializeField] private float _speed = 1.4f;
    [SerializeField] private bool _enable = true;

    void Start()
    {
        
    }

    public bool CheckToImplement()
    {
        bool canImplement = true;

        if (_transformPoints.Count <= 1)
        {
            canImplement = false;
        }

        return canImplement;
    }

    public void TryToImplement(bool canImplement)
    {
        if (!canImplement || !_enable)
        {
            return;
        }

        if((transform.position - _transformPoints[_nextIndexOfTarget].position).magnitude <= _minDistanceToArrive)
        {
            if (_nextIndexOfTarget == _transformPoints.Count - 1)
            {
                _nextIndexOfTarget = 0;
            }
            else
            {
                _nextIndexOfTarget++;
            }
            
        }

        _currentDirection = _transformPoints[_nextIndexOfTarget].position - transform.position;
        transform.position += (_currentDirection.normalized * _speed) * Time.deltaTime;

    }
}
