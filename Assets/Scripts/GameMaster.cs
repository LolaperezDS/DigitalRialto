using UnityEngine;

public class GameMaster : MonoBehaviour
{
    private DataStruct balance;
    private EventManager eventManager;

    private void Start()
    {
        FirstRunApp.SetUp();
        Application.targetFrameRate = 120;
        eventManager = GetComponent<EventManager>();
        balance = SaveManager.Load();
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
        SaveManager.Save(balance);
    }


    public void ChangeCourse(float value)
    {
        balance.rublesInDollar *= value;
    }

    public bool GetIsDollar()
    {
        return balance.isDollar;
    }

    public float GetCount()
    {
        return balance.count;
    }

    public float GetCourse()
    {
        return balance.rublesInDollar;
    }
}
