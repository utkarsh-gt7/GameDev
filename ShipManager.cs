using UnityEngine;

public class ShipManager : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 2f);
    }

    private void OnMouseDown()
    {
        Debug.Log("HIT");
        Destroy(gameObject);
    }
}