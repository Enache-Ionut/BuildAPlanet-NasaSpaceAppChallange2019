using System.Globalization;
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

    public void UpdateLabel2(float value)
    {
        Text lbl = GetComponent<Text>();

        NumberFormatInfo setPrecision = new NumberFormatInfo();

        setPrecision.NumberDecimalDigits = 2;

        if (lbl != null)
            if (value * 100 < 1)
                lbl.text = (value * 100).ToString("N", setPrecision) + "%";
            else
                lbl.text = Mathf.RoundToInt(value * 100) + "%";
    }

    public void UpdateLabelNo(float value)
    {
        Text lbl = GetComponent<Text>();

        Vector3 scale1 = new Vector3(1f, 1f, 1f);
        if (int.Parse(lbl.text) < value)
            planet.transform.localScale += value / 4000000 * scale1;
        else
            planet.transform.localScale -= value / 4000000 * scale1;
        if (value == 4000)
            planet.transform.localScale = scale1;

        if (lbl != null)
            lbl.text = value.ToString();
    }
}
