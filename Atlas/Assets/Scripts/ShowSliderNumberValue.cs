using System.Reflection.Emit;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class ShowSliderNumberValue : MonoBehaviour
{
    public void UpdateLabel(int value)
    {
        Text lbl = GetComponent<Text>();
        if (lbl != null)
            lbl.text = value.ToString();
    }
}
