using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public DataStruct balance;
    public EventManager eventManager;

    private void Start()
    {
        FirstRunApp.SetUp();
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
}
