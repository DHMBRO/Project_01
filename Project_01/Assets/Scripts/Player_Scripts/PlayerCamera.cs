using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private Camera _playerCamera;
    [SerializeField] private float _senseCamera = 1.0f;

    float _senseMouseY;
    float _senseMouseX;
    
    void Start()
    {
        if (!_playerCamera)
        {
            Debug.LogError(gameObject.name + " : Not set ( Camera ) component !");
        }
    }

    public void TryToImplement()
    {
        _senseMouseY = Input.GetAxisRaw("Mouse Y") * _senseCamera;
        _senseMouseX = Input.GetAxisRaw("Mouse X") * _senseCamera;

        _playerCamera.transform.localRotation *= Quaternion.Euler(-_senseMouseY, 0.0f, 0.0f);
        transform.localRotation *= Quaternion.Euler(0.0f, _senseMouseX, 0.0f);
        
    }
}