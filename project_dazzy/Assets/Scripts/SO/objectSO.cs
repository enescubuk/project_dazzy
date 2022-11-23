using UnityEngine;

[CreateAssetMenu(menuName ="Game/Object")]
public class objectSO : ScriptableObject
{
    public string selectableTag;
    public Material onObject;
    public Material selectingObject;
    public Material defaultMaterial;
    public float objectDragSpeed;
}
