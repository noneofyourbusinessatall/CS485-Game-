using UnityEngine;
using System.Collections;
public class BasicMove : MonoBehaviour {
    public Transform target;
    public Transform myTransform;

    void Update() {
        myTransform.LookAt(target);
        myTransform.Translate(Vector3.forward * 1 * Time.deltaTime);
    }
}