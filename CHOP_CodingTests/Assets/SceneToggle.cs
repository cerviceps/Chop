using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneToggle : MonoBehaviour
{
    public GameObject panel;

    public void Update()
    {
        if (Input.GetKeyUp("t"))
        {
			Application.LoadLevel("PancakeScene01");
            
            }
		if (Input.GetKeyUp("g"))
		{
			Application.LoadLevel("SoupScene01");

        }
			
		if (Input.GetKeyUp ("h")) {

			Application.LoadLevel("EggScene01");
		}

		if (Input.GetKeyUp ("b")) {
			
			Application.LoadLevel ("TroutScene01");
		}

		if (Input.GetKeyUp ("y")) {

			Application.LoadLevel ("PizzaScene01");
		}

		if (Input.GetKeyUp ("r")) {

			Application.LoadLevel ("LevelDesign01");

		}

		if (Input.GetKeyUp ("c")) {

			Application.LoadLevel ("CaveScene02");

		}
    }
}
