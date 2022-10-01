using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public DataStruct balance;
    public EventManager eventManager;

    private void Start()
    {
        eventManager = GetComponent<EventManager>();
        balance = new DataStruct();
        EventList.SetUp();
        eventManager.SetUp();
    }

    public void SwitchValue()
    {
        if (balance.isDollar)
        {
            balance.count *= balance.rublesInDollar;
        }
        else
        {
            balance.count /= balance.rublesInDollar;
        }
        balance.isDollar = !balance.isDollar;
    }


    public void ChangeCourse(float value)
    {
        balance.rublesInDollar *= value;
    }
}
