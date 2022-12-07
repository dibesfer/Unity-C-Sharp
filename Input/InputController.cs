
using System.Drawing;
//using System.Numerics;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class InputController : MonoBehaviour
{
    Transform cam;
    [SerializeField] Joystick joystickMove;
    [SerializeField] Joystick joystickRotate;
    [SerializeField] float speed = 10;
    [SerializeField] float speedRotate = 0.2f;
    [SerializeField] Rigidbody rb;
    [SerializeField] Transform directional;
    bool jump;
    float rotateV;
    float rotateH;
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.transform;
    }

    public void Jump()
    {
        rb.velocity += Vector3.up * speed;
    }
    void Move()
    {
        {
            rb.velocity = new Vector3(
                joystickMove.Horizontal * speed + Input.GetAxis("Horizontal"),
                rb.velocity.y, 
                joystickMove.Vertical * speed + Input.GetAxis("Vertical")
                );
        }
    }
    void Rotate()
    {        rotateH = joystickRotate.Horizontal * speedRotate;
        rotateV = joystickRotate.Vertical * speedRotate;
        //rotateH = joystickRotate.Horizontal * speedRotate;
        //rotateV = -(joystickRotate.Vertical * speedRotate);
        //direction = new Vector3(0, rotateH, 0);
        //cam.Rotate(rotateV, rotateH, 0);   
        //directional.LookAt(gameObject.transform, direction);

        //Take the vector at which joystick is pointed and use math to get heading:
        float heading = Mathf.Atan2(rotateH, rotateV);
        if (heading != 0) { 
       // It is heading in radians which can be used to point the object in right direction like:

        directional.rotation = Quaternion.Euler(0, heading * Mathf.Rad2Deg, 0);}
        //https://answers.unity.com/questions/816119/top-down-2d-how-can-i-rotate-my-player-to-look-at.html
    }
    private void Update()
    {
        Move();
        Rotate();
    }
}
