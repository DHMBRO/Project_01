using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private PlayerMovement _playerMovement;
    private PlayerCamera _playerCamera;

    [SerializeField] private CursorLockMode cursorLockMode = CursorLockMode.None;

    void Start()
    {
        _playerMovement = GetComponent<PlayerMovement>();   
        _playerCamera = GetComponent<PlayerCamera>();        

        if (!_playerMovement) Debug.LogError(gameObject.name + " : Not set ( PlayerMovement ) component !");
        if (!_playerCamera) Debug.LogError(gameObject.name + " : Not set ( PlayerCamera ) component !");

    }

    private void SetCursor()
    {
        switch (cursorLockMode)
        {
            case CursorLockMode.None:
                cursorLockMode = CursorLockMode.Locked;
                break;
            case CursorLockMode.Locked:
                cursorLockMode = CursorLockMode.None;
                break;
            case CursorLockMode.Confined:
                cursorLockMode = CursorLockMode.None;
                break;
        }

        Cursor.lockState = cursorLockMode; 
    }

    void Update()
    {
        // Input         
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            SetCursor();
        }

        if (cursorLockMode == CursorLockMode.None)
        {
            return;
        }

        // Implmentation of functions        
        _playerMovement.TryToImplement();
        _playerCamera.TryToImplement();
    }
}
