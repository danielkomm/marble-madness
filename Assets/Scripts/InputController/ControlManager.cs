using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public enum ActiveControlEnum{Player, Cannon};

public class ControlManager : MonoBehaviour
{
    public UnityEvent activeControlChanged = new UnityEvent();

    public static ControlManager Instance{get{return _instance;}}
    public ActiveControlEnum ActiveControl{ get; private set;}

    private  static ControlManager _instance;
    private void Awake()
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
    public void Start(){
        ActiveControl = ActiveControlEnum.Player;
        activeControlChanged.Invoke();
    }


    public void SetActiveControl(ActiveControlEnum newActiveCon){
        ActiveControl =  newActiveCon;
        activeControlChanged.Invoke();
    }
}
