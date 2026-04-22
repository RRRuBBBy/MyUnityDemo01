using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text statusText;
    public TMP_Text tempText;

    private DeviceController currentDevice;

    void Update()
    {
        if (currentDevice != null)
        {
            nameText.text = currentDevice.deviceName;
            statusText.text = currentDevice.isRunning ? "运行中" : "已停止";
            tempText.text = currentDevice.temperature.ToString("F1");
        }
    }

    public void SetDevice(DeviceController device)
    {
        currentDevice = device;
    }
}