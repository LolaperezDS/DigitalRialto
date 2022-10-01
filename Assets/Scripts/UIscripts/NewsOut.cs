using UnityEngine;
using UnityEngine.UI;

public class NewsOut : MonoBehaviour
{
    public void SetNews(string data)
    {
        GetComponent<Text>().text = "News: " + data;
    }
}
