
using UnityEngine;

public class finishTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider Other)
    {
        Debug.Log("Finished the level");
    }
}
