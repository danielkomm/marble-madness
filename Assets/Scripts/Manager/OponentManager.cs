using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum StatsRestrains
{
    Mud,
    Default,
}
public class OponentManager : MonoBehaviour
{
    public UnityEvent playerStatsChanged = new UnityEvent();

    private static OponentManager _instance;
    public static OponentManager Instance { get { return _instance; } }
    public float dragValue { get { return _drag; } }
    private float _drag;
    private StatsRestrains _currentRestrain;


    void Start()
    {
        _drag = 0;
        _currentRestrain = StatsRestrains.Default;
    }

    void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    public void ChangePlayerSpeed(float drag, StatsRestrains state)
    {
        Debug.Log("Current Restrain " + _currentRestrain);        
        if (_currentRestrain != state)
        {
            Debug.Log("Apply slowness " + state);
            this._drag += drag;
            playerStatsChanged.Invoke();
            _currentRestrain = state;
        }
    }


    public void ResetPlayerSpeed()
    {
        this._drag = 0;
        _currentRestrain = StatsRestrains.Default;
        playerStatsChanged.Invoke();
    }
}
