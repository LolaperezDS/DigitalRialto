using UnityEngine;

public class AutoDisableTutorCanvas : MonoBehaviour
{
    private Canvas canvTutorial;
    private void Start()
    {
        canvTutorial = GetComponent<Canvas>();
        Invoke(nameof(DisableCanv), 2);
    }

    private void DisableCanv()
    {
        canvTutorial.enabled = false;
    }
}
