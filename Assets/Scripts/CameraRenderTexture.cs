using UnityEngine;

[ExecuteInEditMode]
public class CameraRenderTexture : MonoBehaviour
{
    public Material Mat;

    public float level;

    public void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, Mat);
    }

    private void Update()
    {
        Mat.SetFloat("_RedX", Random.Range(-0.01f, 0.01f));
        Mat.SetFloat("_RedY", Random.Range(-0.01f, 0.01f));
        Mat.SetFloat("_GreenX", Random.Range(-0.01f, 0.01f));
        Mat.SetFloat("_GreenY", Random.Range(-0.01f, 0.01f));
        Mat.SetFloat("_BlueX", Random.Range(-0.01f, 0.01f));
        Mat.SetFloat("_BlueY", Random.Range(-0.01f, 0.01f));
    }
}
