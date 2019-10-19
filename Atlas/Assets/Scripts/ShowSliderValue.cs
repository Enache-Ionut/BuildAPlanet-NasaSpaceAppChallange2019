using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ShowSliderValue : MonoBehaviour
{
    public GameObject planet;
    public void UpdateLabel(float value)
    {
        Text lbl = GetComponent<Text>();
        if (lbl != null)
            lbl.text = Mathf.RoundToInt(value * 100) + "%";
    }

    public void UpdateLabelNo(float value)
    {
        Text lbl = GetComponent<Text>();
        if (lbl != null)
            lbl.text = value.ToString();

        planet.transform.localScale += new Vector3(1f, 1f, 1f);
    }
}
