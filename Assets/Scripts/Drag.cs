using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
	private Vector3 screenPoint;
	private Vector3 offset;
	private bool mouseDown;

	public float rotationSpeed;

	public float groundLevel;

	private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
	    mouseDown = false;
	    _rb = GetComponent<Rigidbody>();
	    
    }

    // Update is called once per frame
    void Update()
    {
	    if (mouseDown & Input.GetKey(KeyCode.A))
	    {
		    transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
	    }
       
	    if (mouseDown & Input.GetKey(KeyCode.D)){
		    transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime);
	    }

	    if (mouseDown & Input.GetKey(KeyCode.W))
	    {
		    transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
	    }

	    if (mouseDown & Input.GetKey(KeyCode.S))
	    {
		    transform.Rotate(-Vector3.forward * rotationSpeed * Time.deltaTime);
	    }
    }
   
    
    // Object dragging logic heavily inspired from Unity forums and StackOverflow
    void OnMouseUp()
    {
	    mouseDown = false;
	    _rb.constraints = RigidbodyConstraints.None;
    }

	void OnMouseDown()
	{
		mouseDown = true;
		_rb.constraints = RigidbodyConstraints.FreezeRotation;
     	screenPoint = Camera.main.WorldToScreenPoint(transform.position);
     	offset =  transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,screenPoint.z));
        _rb.constraints = RigidbodyConstraints.FreezePosition;
        
        
    }

 void OnMouseDrag()
 {
	 Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
     	Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        if (curPosition.y < groundLevel)
        {
	        curPosition.y = groundLevel;
        }
        transform.position = curPosition;
 }
 


}
