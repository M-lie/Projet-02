using UnityEngine;

public class perlinNOise : MonoBehaviour
{
    public int width = 256;
    public int height = 256;

    void start()
    {
        Renderer renderer =  GetComponent<Renderer>();
        renderer.material.mainTexture = GenerateTexture();
    }

    Texture2D GenerateTexture ()
    {
        Texture2D texture = new Texture2D(width, height);

        //generate perlin noise map for texture
        for(int x = 0, x < width; x++)
        {
            for(int y = 0; y < height; y++)
            {
                Color color = CalculateColor(x, y);
                texture.SetPixel(x, y, color);
            }
        }
        return texture;
    }

    Color CalculateColor(int x, int y) {
        float sample = Mathf.PerlinNoise(x, y);
        return new Color (sample, sample, sample);
    }
}
