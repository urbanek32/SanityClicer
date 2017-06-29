using UnityEngine;

public class SkyboxRotator : MonoBehaviour
{
    public float RotationPerSecond = 1;
    public bool RotateSkybox;

    private void Update()
    {
        if (RotateSkybox)
        {
            RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotationPerSecond);
        }
    }

    public void ToggleSkyboxRotation(bool state)
    {
        RotateSkybox = state;
    }
}