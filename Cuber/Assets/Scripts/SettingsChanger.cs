using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsChanger : MonoBehaviour
{
    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}
