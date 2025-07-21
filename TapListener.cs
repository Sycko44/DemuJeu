using UnityEngine;
using UnityEngine.SceneManagement;

public class TapListener : MonoBehaviour
{
    private float[] triggerTimes = {3.0f, 6.0f};
    private float timeElapsed = 0f;
    private bool triggered = false;

    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (Input.GetMouseButtonDown(0) && !triggered)
        {
            if (timeElapsed >= triggerTimes[0] && timeElapsed <= triggerTimes[1])
            {
                triggered = true;
                SceneManager.LoadScene("Cuisine_Scene");
            }
        }
    }
}
