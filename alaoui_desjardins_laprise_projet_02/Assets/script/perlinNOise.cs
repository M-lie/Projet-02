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
        for(int x = 0; x < width; x++)
        {
            for(int y = 0; y < height; y++)
            {
                Color color = CalculateColor(x, y);
                texture.SetPixel(x, y, color);
            }
        }
        texture.Apply();
        return texture;
    }

    Color CalculateColor(int x, int y) 
    {
        float xCoord = (float)x / width;
        float yCoord = (float)y / height;

        float sample = Mathf.PerlinNoise(xCoord, yCoord);
        return new Color (sample, sample, sample);
    }
}
