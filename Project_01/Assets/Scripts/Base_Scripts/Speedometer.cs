using UnityEngine;

public class Speedometer : MonoBehaviour
{
    [SerializeField] private float _velocity;

    Vector3 _lastPosition;
    private float _timeToCheckVelocity = 0.0f;
    private float _delay = 1.0f;

    private void Start()
    {
        _lastPosition = transform.position;
    }

    void Update()
    {
        if (Time.time >= _timeToCheckVelocity)
        {
            _timeToCheckVelocity = Time.time + _delay;

            _velocity = (transform.position - _lastPosition).magnitude;
            _lastPosition = transform.position;
        }
    }
    
    public float GetVelocity()
    {
        return _velocity;
    }
}
