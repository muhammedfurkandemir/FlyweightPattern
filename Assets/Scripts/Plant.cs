using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plant : MonoBehaviour
{
    [SerializeField]
    private PlantData info;
    SetPlantInfo spi;
   
    private void Start()
    {
        spi = GameObject.FindWithTag("PlantInfo").GetComponent<SetPlantInfo>();
       
    }
    private void OnMouseDown()
    {
        spi.OpenPlantPanel();
        spi.plantName.text = info.PlantName;
        spi.threatLevel.text = info.PlantThreat.ToString();
        spi.plantIcon.GetComponent<RawImage>().texture = info.Icon;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")&& info.PlantThreat==PlantData.THREAT.high)
        {
            print("içerde");
            PlayerController.dead = true;
                     
        }
    }
}
