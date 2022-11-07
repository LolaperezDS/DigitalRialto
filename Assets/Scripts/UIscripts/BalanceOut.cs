using UnityEngine;
using UnityEngine.UI;

public class BalanceOut : MonoBehaviour
{
    [SerializeField] private GameObject mainObj;

    private void Update()
    {
        string output = "Balance: " + System.Math.Round((decimal)mainObj.GetComponent<GameMaster>().GetCount(), 2).ToString();
        if (mainObj.GetComponent<GameMaster>().GetIsDollar())
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
