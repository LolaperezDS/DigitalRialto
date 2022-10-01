using UnityEngine;
using UnityEngine.UI;

public class ButtonConvert : MonoBehaviour
{
	[SerializeField] private GameObject mainObj;
	void Start()
	{
		GetComponent<Button>().onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		mainObj.GetComponent<GameMaster>().SwitchValue();
	}
}
