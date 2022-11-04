using UnityEngine;

public class EventManager : MonoBehaviour
{
    [SerializeField] private GameObject news;
    public int timerate = 3;
    private EventRialto e;
    public void SetUp()
    {
        e = EventList.GetrandomEventRialto();
        news.GetComponent<NewsOut>().SetNews(e.news);

        Invoke(nameof(CallEventRecurse), timerate);
    }

    private void CallEventRecurse()
    {
        GetComponent<GameMaster>().ChangeCourse(e.GetTotalPercent());

        Invoke(nameof(CallEventRecurse), timerate);

        e = EventList.GetrandomEventRialto();
        news.GetComponent<NewsOut>().SetNews(e.news);
    }
}
