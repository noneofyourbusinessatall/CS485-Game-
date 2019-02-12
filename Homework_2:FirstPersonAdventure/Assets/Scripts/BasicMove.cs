using UnityEngine;
using System.Collections;
public class BasicAI : MonoBehaviour {
    public Transform target;
    public Transform myTransform;

    void Update() {
        myTransform.LookAt(target);
        myTransform.Translate(Vector3.forward * 5 * Time.deltaTime);
    }
}