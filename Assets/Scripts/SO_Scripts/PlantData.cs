using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="plantdata",menuName ="Plant Data",order =51)]
//bu yapı ile create asset  kısmında bir alan oluşturarak yeni asset oluşturma imaknı verir.file name dosya adını menu name menude gözükecek
//adı order ise oluşturulacağı kısmı verir.unity en son 60 ye kadar alanı kullandığı için yeni bir alan için 51 i kullandık.
public class PlantData :ScriptableObject
{
    public enum THREAT { none,low,moderate,high}

    [SerializeField]
    private string plantName;
    [SerializeField]
    private THREAT plantThreat;
    [SerializeField] Texture icon;

    public string PlantName { get { return plantName; } }
    public THREAT PlantThreat { get { return plantThreat; } }
    public Texture Icon { get { return icon; } }
}
