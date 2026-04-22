using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    public UIManager uiManager;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                var device = hit.collider.GetComponent<DeviceController>();
                if (device != null)
                {
                    uiManager.SetDevice(device);
                }
            }
        }
    }
}