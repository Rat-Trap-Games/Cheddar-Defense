using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed;
    public float moveHorizontal;
    public float moveVertical;

    void Update()
    {
        moveHorizontal = Input.GetAxisRaw ("PlayerHorizontal");
        moveVertical = Input.GetAxisRaw ("PlayerVertical");
  
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        if(moveHorizontal != 0 || moveVertical != 0){
            transform.rotation = Quaternion.LookRotation(movement);
        }
  
        transform.Translate (movement * movementSpeed * Time.deltaTime, Space.World);
    }

    void OnCollisionEnter(Collision col) { 
        Debug.Log(col.gameObject.tag);
    }
}