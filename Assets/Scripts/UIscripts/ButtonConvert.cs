using UnityEngine;
using UnityEngine.UI;

public class ButtonConvert : MonoBehaviour
{
	[SerializeField] private GameObject mainObj;
	private Animation pulse;
	void Start()
	{
		pulse = GetComponent<Animation>();
		GetComponent<Button>().onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		mainObj.GetComponent<GameMaster>().SwitchValue();


		if (pulse.isPlaying)
        {
			pulse.Stop();
        }
		pulse.Play();
	}
}
