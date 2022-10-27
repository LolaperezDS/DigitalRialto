using UnityEngine;
using UnityEngine.UI;

public class BalanceOut : MonoBehaviour
{
    [SerializeField] private GameObject mainObj;

    private void Update()
    {
        string output = "Balance: " + System.Math.Round((decimal)mainObj.GetComponent<GameMaster>().balance.count, 2).ToString();
        if (mainObj.GetComponent<GameMaster>().balance.isDollar)
        {
            output += "$";
        }
        else
        {
            output += "R";
        }
        GetComponent<Text>().text = output;
    }
}
