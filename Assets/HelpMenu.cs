using UnityEngine;
using UnityEngine.UI;

public class HelpMenu : MonoBehaviour
{
    public Toggle toggleButton;
    public GameObject helpText;

    public void ToggleHelp()
    {
        if (toggleButton.isOn == true) {
            helpText.SetActive(true);
        }
        else {
            helpText.SetActive(false);
        }
    }
}
