 using UnityEngine;
 using System.Collections;
 
 [RequireComponent (typeof(Rigidbody))]
 public class trythis : MonoBehaviour {
 
     public float movementSpeed = 5.0f;
     public float clockwise = 1000.0f;
     public float counterClockwise = -5.0f;
 
     void Start () {
         
     }
     
     void Update () {
         if(Input.GetKey(KeyCode.W)) {
              transform.position += transform.forward * Time.deltaTime * movementSpeed;
         }
         else if(Input.GetKey(KeyCode.S)) {
              transform.position -= transform.forward * Time.deltaTime * movementSpeed;
         }
         else if(Input.GetKey(KeyCode.A)) {
             GetComponent<Rigidbody>().position += Vector3.left * Time.deltaTime * movementSpeed;
         }
         else if(Input.GetKey(KeyCode.D)) {
             GetComponent<Rigidbody>().position += Vector3.right * Time.deltaTime * movementSpeed;
         }
 
         if(Input.GetKey(KeyCode.E)) {
             transform.Rotate(0, Time.deltaTime * clockwise, 0);
         }
         else if(Input.GetKey(KeyCode.Q)) {
             transform.Rotate(0, Time.deltaTime * counterClockwise, 0);
         }
     }
 }