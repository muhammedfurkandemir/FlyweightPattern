using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCar : MonoBehaviour
{
    public GameObject car;
    public GameObject _camera;
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 pos = new Vector3(11, 11, 11);
            GameObject c = Instantiate(car, pos,Quaternion.identity);
            _camera.GetComponent<SmoothFollow>().target = car.transform;
        }
    }
}
