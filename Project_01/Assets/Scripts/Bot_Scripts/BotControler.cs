using UnityEngine;

public class BotControler : MonoBehaviour
{
    [SerializeField] private BotNavigationSystem _botNavigationSystem;
    [SerializeField] private bool _enable;

    void Start()
    {
        _botNavigationSystem = GetComponent<BotNavigationSystem>();
    }

    void Update()
    {
        if(!_enable)
        {
            return;
        }

        //  Implmentation 
        _botNavigationSystem.TryToImplement(_botNavigationSystem.CheckToImplement());

    }
}
