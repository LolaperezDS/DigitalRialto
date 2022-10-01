using System.Collections.Generic;
using UnityEngine;

public class EventRialto
{
    public string news;
    public float lowChange;
    public float highChange;
    public float rate;

    public EventRialto(string news, float lowChange, float highChange, float rate)
    {
        this.news = news; this.lowChange = lowChange; this.highChange = highChange; this.rate = rate;
    }

    public float GetTotalPercent()
    {
        return 1f + Random.Range(lowChange, highChange);
    }
}


public static class EventList
{
    private static List<EventRialto> events = new List<EventRialto>();

    public static void SetUp()
    {
        events.Add(new EventRialto("Rialto Is OK", -0.01f, 0.01f, 20));
        events.Add(new EventRialto("Inflation $", -0.05f, -0.02f, 5));
        events.Add(new EventRialto("Inflation R", 0.02f, 0.05f, 5));
        events.Add(new EventRialto("Crisis $", -0.2f, -0.1f, 1));
        events.Add(new EventRialto("Crisis R", 0.1f, 0.2f, 1));
    }

    public static EventRialto GetrandomEventRialto()
    {
        float rateModule = 0f;
        foreach (EventRialto e in events)
        {
            rateModule += e.rate;
        }
        float dotOfRialto = Random.Range(0f, 1f);
        float sliderRialto = 0;
        foreach (EventRialto e in events)
        {
            if (dotOfRialto >= sliderRialto && dotOfRialto <= sliderRialto + e.rate / rateModule)
            {
                return e;
            }
            sliderRialto += e.rate / rateModule;
        }
        return null;
    }
}