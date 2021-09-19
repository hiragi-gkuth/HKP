using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CountdownTimer : MonoBehaviour
{
    #region field

    public List<UnityEvent> EventList = new List<UnityEvent>();
    public float countdownTime;
    [SerializeField] private float countdowningTime;
    [SerializeField] private bool stopper = false;

    #endregion

    #region func
    public void Initialize()
    {
        countdowningTime = countdownTime;
    }

    public void OnUpdate()
    {
       if(stopper==false) countdowningTime -= Time.time;
        if (countdowningTime <= 0) OnCallEvent();
    }

    public void OnCallEvent() {
        foreach(var x in EventList) { x.Invoke(); }
    }
    #endregion

    #region eventFunc


    public void Start()
    {
        Initialize();
    }
    public void Update()
    {
        OnUpdate();
    }
    #endregion
}
