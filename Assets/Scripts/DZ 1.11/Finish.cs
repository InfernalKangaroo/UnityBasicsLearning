using UnityEngine;

public class Finish : MonoBehaviour

{
    public ParticleSystem _finish;
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.TryGetComponent(out Player player)) return;
        player.ReachFinish();
        _finish = GetComponent<ParticleSystem>();
        _finish.Play();
    }
}
