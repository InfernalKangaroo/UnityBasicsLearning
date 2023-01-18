using UnityEngine;

public class coinTrigger : MonoBehaviour
{
   private void OnTriggerEnter (Collider Other)
    {
        gameObject.SetActive(false);
        Debug.Log("coin collected");
    }
}
