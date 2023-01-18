using System.Collections;
using UnityEngine;

namespace Assets.Scripts.DZ_1._11
{
    public class Platform : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if(other.TryGetComponent(out Player player))
            {
                player.CurrentPlatform = this;

            }
        }
    }
}