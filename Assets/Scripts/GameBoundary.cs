using Unity.VisualScripting;
using UnityEngine;

public class GameBoundary : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(collision.GameObject());
    }
}
