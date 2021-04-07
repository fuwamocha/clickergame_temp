using UnityEngine;

public class EffectControl : MonoBehaviour {

    ParticleSystem[] array;
    [SerializeField]
    private Camera _camera;
    public GameObject effect;

    private void Start() {

        array = GetComponentsInChildren<ParticleSystem>();
    }

    void Update() {
        if (Input.GetMouseButton(0)) {
            effect.gameObject.SetActive(true);

            var pos = Input.mousePosition;
            pos.z = 9f;

            transform.position = _camera.ScreenToWorldPoint(pos);
            effect.transform.position = _camera.ScreenToWorldPoint(pos);

            array[0].Play();
            array[1].Play();
            array[2].Play();
        }
        else {
            effect.gameObject.SetActive(false);
        }
    }
}
