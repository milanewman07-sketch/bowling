using UnityEngine;

public class BallThrow : MonoBehaviour
{
        public float power = 1f;
        public float spin = 0f;
        private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && power < 3f){
            power += 1f * Time.deltaTime;
            Debug.Log(power);
        }

        if (Input.GetKey(KeyCode.S) && 0f < power){
            power -= 1f * Time.deltaTime;
            Debug.Log(power);
        }

        if (Input.GetKey(KeyCode.A)) {
            transform.position += Vector3.right * 1 * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D)) {
            transform.position -= Vector3.right * 1 * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.E) && spin < 50f){
            spin += 10f * Time.deltaTime;
            Debug.Log(spin);
        }

        if (Input.GetKey(KeyCode.Q) && 50f < spin){
            spin -= 10f * Time.deltaTime;
            Debug.Log(spin);
        }

        if (Input.GetKey(KeyCode.Space)) {
            rb.AddForce(new Vector3 (0.0f, 0.0f, -power * 50f));
            rb.AddTorque(Vector3.up * spin * 100 * Time.deltaTime);
        }
    }
}
