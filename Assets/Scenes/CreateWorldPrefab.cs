using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWorldPrefab : MonoBehaviour
{
    public int width;
    public int depth;
    public GameObject cube;
    void Start()
    {
        for (int x = 0; x < width; x++)
            for (int z = 0; z < depth; z++)//x*z ebatlarında küplerden oluşan bir görüntü elde etmemizi sağladı.
            {
                Vector3 pos = new Vector3(x,
                    Mathf.PerlinNoise(x * 0.2f, z * 0.2f) * 3f//perlin noise ile terrain oluşturmamızı sağlayın değerler arasında yumuşatma oluşturarak 
                                                              //random yükseklik değerleri almamızı sağlayan bir algoritmadır.
                    , z);//x ve z ye göre pozisyonlar almamızı sağlar.
                GameObject go = Instantiate(cube, pos, Quaternion.identity);
            }

    }
    void Update()
    {
        

    }
}
