using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopWatch : MonoBehaviour
{
    public float countUpTime;
    [SerializeField]private bool stopper=false;

    public void Initialize()
    {
        countUpTime = 0;
        stopper = false;
    }


    public void Start()
    {
        Initialize();
    }
    public void Update(){
        if (stopper == false) countUpTime += Time.time;
    }
 
}