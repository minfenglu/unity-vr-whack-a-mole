using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{
    public float visibleHeight = 0.2f;
    public float hiddenHeight = -0.3f;
    public float speed = 1f;

    private Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = new Vector3(
            transform.localPosition.x,
            visibleHeight,
            transform.localPosition.z
        );
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = Vector3.Lerp(transform.localPosition, targetPosition, Time.deltaTime * speed);
    }

    public void OnHit() {
        targetPosition = new Vector3(
            transform.localPosition.x,
            hiddenHeight,
            transform.localPosition.z
        );
    }
}
