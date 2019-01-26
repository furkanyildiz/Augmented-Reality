using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public float speed = 3f;
    public int rotAngle = 180;
    public float rotationSpeed = 50.0f;

    private float xDistance = 20.0f;

    public bool animate = true;

    private Vector3 firstPos;
    private Vector3 targetPos;

    private void Start()
    {
        firstPos = transform.position;
        targetPos = firstPos;
        targetPos.x += xDistance;

        StartCoroutine(UpdateAnim());
    }

    private IEnumerator UpdateAnim()
    {
        while (animate)
        {
            while (Vector3.Distance(transform.position, targetPos) > 1.0f)
            {
                transform.Translate(Vector3.right * Time.deltaTime * speed);
                yield return null;
            }
            /*
            while (transform.rotation.eulerAngles.y < rotAngle)
            {
                transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
                yield return null;
            }

            while (Vector3.Distance(transform.position, firstPos) > 1.0f)
            {
                transform.Translate(Vector3.right * Time.deltaTime * speed);
                yield return null;
            }

            while (transform.rotation.eulerAngles.y > 180)
            {
                transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
                yield return null;
            }
            */
            yield return null;
        }
    }

}