using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {


	public GameObject dBox;
	public SuperTextMesh dText;

	public Animation anim;

	//yield return new WaitForSeconds(anim);


	 IEnumerator playFadeOut(){

		Debug.Log ("faded out!");
		anim.Play ("DialogueManager_FadeOut");

		yield return new WaitForSeconds (5);
		Debug.Log ("Waited for 5 seconds.");

	}

	IEnumerator deactivateDialogue(){

		Debug.Log ("deactivated the dialogue!");
		dBox.SetActive (false);
		dialogueActive = false;

		yield return new WaitForSeconds (3);

	}
		
	void dialogue ()
	{
	}


	public bool dialogueActive;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

		if (dialogueActive && Input.GetKeyDown(KeyCode.Space))
		{
			StartCoroutine ("playFadeOut");

			StartCoroutine ("deactivateDialogue");

		}

	}

	public void ShowBox(string dialogue) 
	{
		dialogueActive = true;
		dBox.SetActive (true);
		dText.text = dialogue;
	}
}
