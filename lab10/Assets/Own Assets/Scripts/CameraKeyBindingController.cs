using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.ImageEffects;

public class CameraKeyBindingController : MonoBehaviour
{
    public Text notes;

    // Update is called once per frame
    void Update()
    {
        // Ctrl+H combo - "Sun Shafts" Effect
        if ((Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftControl)) && Input.GetKeyDown(KeyCode.H))
        {
            if (false == GetComponent<SunShafts>().enabled)
            {
                GetComponent<SunShafts>().enabled = true;
            }
            else
            {
                GetComponent<SunShafts>().enabled = false;
            }
        }

        // E key - "Edge Detection" Effect
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (false == GetComponent<EdgeDetection>().enabled)
            {
                GetComponent<EdgeDetection>().enabled = true;
            }
            else
            {
                GetComponent<EdgeDetection>().enabled = false;
            }
        }

        // B key - "Bloom Optimised" Effect
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (false == GetComponent<BloomOptimized>().enabled)
            {
                GetComponent<BloomOptimized>().enabled = true;
            }
            else
            {
                GetComponent<BloomOptimized>().enabled = false;
            }
        }

        // I key - show/hide notes
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (true == notes.enabled)
            {
                notes.enabled = false;
            }
            else
            {
                notes.enabled = true;
            }
        }
    }
}
