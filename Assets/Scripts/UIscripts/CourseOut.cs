using UnityEngine;
using UnityEngine.UI;

public class CourseOut : MonoBehaviour
{
    [SerializeField] private GameObject mainObj;

    void Update()
    {
        GetComponent<Text>().text = "1$ = " + mainObj.GetComponent<GameMaster>().GetCourse().ToString() + "R";
    }
}
