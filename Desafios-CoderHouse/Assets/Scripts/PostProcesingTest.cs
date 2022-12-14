using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcesingTest : MonoBehaviour
{
    public PostProcessVolume volumen;
    private Bloom _bloom;

    void Start()
    {
        volumen.profile.TryGetSettings(out _bloom);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.transform.gameObject.name == "Player")
        {
            _bloom.intensity.value = 0;
        }
    }
}   