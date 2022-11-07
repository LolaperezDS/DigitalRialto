using System.Collections.Generic;
using UnityEngine;

public class EventRialto
{
    private string news;
    private float lowChange;
    private float highChange;
    private float rate;

    public EventRialto(string news, float lowChange, float highChange, float rate)
    {
        this.news = news; this.lowChange = lowChange; this.highChange = highChange; this.rate = rate;
    }

    public float GetTotalPercent()
    {
        return 1f + Random.Range(lowChange, highChange);
    }

    public string GetNewsText()
    {
        return news;
    }

    public float GetRate()
    {
        return rate;
    }
}


public static class EventList
{
    private static List<EventRialto> events = new List<EventRialto>();
    private static float rateModule;

    public static void SetUp()
    {
        /* List of messages:
         * 
         * Rialto Is OK
         * Inflation $
         * Inflation R
         * Crisis $
         * Crisis R
         * the market is pretty stable
         * the dollar is expected to fall in the market
         * the ruble is expected to fall in the market
         * collapse of the ruble
         * collapse of the dollar
         */
        events.Add(new EventRialto("Rialto Is OK", -0.01f, 0.01f, 20));
        events.Add(new EventRialto("the market is pretty stable", -0.01f, 0.01f, 20));
        events.Add(new EventRialto("Inflation $", -0.05f, -0.02f, 5));
        events.Add(new EventRialto("the dollar is expected to fall in the market", -0.05f, -0.02f, 5));
        events.Add(new EventRialto("Inflation R", 0.02f, 0.05f, 5));
        events.Add(new EventRialto("the ruble is expected to fall in the market", 0.02f, 0.05f, 5));
        events.Add(new EventRialto("Crisis $", -0.2f, -0.1f, 1));
        events.Add(new EventRialto("Crisis R", 0.1f, 0.2f, 1));
        events.Add(new EventRialto("collapse of the dollar", -0.2f, -0.1f, 1));
        events.Add(new EventRialto("collapse of the ruble", 0.1f, 0.2f, 1));


        rateModule = 0f;
        foreach (EventRialto e in events)
        {
            rateModule += e.GetRate();
        }
    }

    public static EventRialto GetRandomEventRialto()
    {
        float dotOfRialto = Random.Range(0f, 1f);
        float sliderRialto = 0;
        foreach (EventRialto e in events)
        {
            if (dotOfRialto >= sliderRialto && dotOfRialto <= sliderRialto + e.GetRate() / rateModule)
            {
                return e;
            }
            sliderRialto += e.GetRate() / rateModule;
        }
        return null;
    }
}