using UnityEngine;

public class Player : MonoBehaviour {

    Vector3 newPosition;
    public float runSpeed = 10f;
    public float jumpSpeed = 10f;

    // ------------------------------------------------------------------------
	// Use this for initialization
	void Start () {
        newPosition = transform.position;
	}
    // ------------------------------------------------------------------------
    void Update()
    {
        GetComponent<Animator>().SetFloat("Run", GetComponent<Rigidbody2D>().velocity.magnitude);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-runSpeed, 0));
            GetComponent<SpriteRenderer>().flipX = false;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(runSpeed, 0));
            GetComponent<SpriteRenderer>().flipX = true;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpSpeed));
        }
    }

    /*
        // ------------------------------------------------------------------------
        // Update is called once per frame
        void Update () {
            Jump();
            float horizontalMove = Input.GetAxis("Horizontal");
            if (System.Math.Abs(horizontalMove) > 0)
            {
                Debug.Log(horizontalMove);
            }
            Vector3 movement = new Vector3(horizontalMove, 0f, 0f);
            transform.position += movement * Time.deltaTime * runSpeed;
        }
        // ------------------------------------------------------------------------
        void Jump()
        {
            if (Input.GetButtonDown("Jump"))
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 7f), ForceMode2D.Impulse);
            }
        }
    */
}
