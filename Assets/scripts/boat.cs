using UnityEngine;
using System.Collections;
using scripts;

public class boat : MonoBehaviour {

	public float turnSpeed = 1000f;
	public float accellerateSpeed = 1000f;
	private GameManager gm;


	private Rigidbody rbody;

	// Use this for initialization
	void Start () 
	{
		gm = GameManager.GetInstance();

		rbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		gm = GameManager.GetInstance();
		if (gm.gameState != GameManager.GameState.GAME &
			 gm.gameState != GameManager.GameState.RESUME)
		{
			return;
		}

		if (Input.GetKeyDown(KeyCode.Escape) && (gm.gameState == GameManager.GameState.GAME || gm.gameState != GameManager.GameState.RESUME))
		{
			gm.ChangeState(GameManager.GameState.PAUSE);
		}

		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		rbody.AddTorque(0f,h*turnSpeed*Time.deltaTime,0f);
		rbody.AddForce(transform.forward*v*accellerateSpeed*Time.deltaTime);


	}
}
