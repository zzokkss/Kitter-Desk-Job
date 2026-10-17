using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Mouse collided with: " +
                  collision.gameObject.name);
    }

}
