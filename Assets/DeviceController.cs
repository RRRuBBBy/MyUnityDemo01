using UnityEngine;

public class DeviceController : MonoBehaviour
{
    public string deviceName = "设备A";
    public bool isRunning = false;
    public float temperature = 25f;

    float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 1f)
        {
            temperature = Random.Range(20f, 80f);
            timer = 0f;
        }
    }

    public void Toggle()
    {
        Debug.Log("按钮点了！");
        isRunning = !isRunning;
    }
}