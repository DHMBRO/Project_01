using UnityEngine;

public class PlayerMovement : MonoBehaviour, IImplementation
{
    // Speed: meters/second 

    //[SerializeField] private float _speedCrouch = 1.0f;
    [SerializeField] private float _speedWalk = 1.4f;
    //[SerializeField] private float _speedJigging = 2.2f;
    //[SerializeField] private float _speedSprinting = 5.6f;

    // Stamina second/points, for now unavailable 

    //[SerializeField] private float _staminaJigging = 0.0f;
    //[SerializeField] private float _staminaSprinting = 0.0f;

    private float _selectedSpeed;
    private float _moveHorizontal;
    private float _moveVertical;

    void Start()
    {
        _selectedSpeed = _speedWalk;    
    }

    public bool CheckToImplement()
    {
        bool canImplement = true;

        return canImplement;
    }

    public void TryToImplement(bool canImplement)
    {
        if (!canImplement)
        {
            return;
        }

        _moveHorizontal = Input.GetAxisRaw("Horizontal");
        _moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = (transform.forward * _moveVertical + transform.right * _moveHorizontal).normalized;

        transform.Translate(direction * _selectedSpeed * Time.deltaTime, Space.World);
    }
}
