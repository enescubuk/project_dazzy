using UnityEngine;

[CreateAssetMenu(menuName ="Object")]
public class objectSO : ScriptableObject
{
    public string selectableTag;
    public Material onObject;
    public Material selectingObject;
    public Material defaultMaterial;
}
