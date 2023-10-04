public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 25;
    public float xRange = 30;
    
    public Transform blaster;
    public GameObject lazerBolt;
   
  

    // Update is called once per frame
    void Update()
    {
        //Initialize HorizontalInput to recieve values from key bindings
        horizontalInput = Input.GetAxis("Horizontal");
        
        // Moves player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        
        //Keep player within bounds
        //Left side wall
        if (transform.position.x < -xRange )
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //Right side wall
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space));
        {
            //Create LazerBolt at blaster transform position maintaining object rotation
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.position);
        }
        
     
    }
    //Deslete any object with a trigger that hits the player
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
