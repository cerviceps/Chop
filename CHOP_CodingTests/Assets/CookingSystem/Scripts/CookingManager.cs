﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingManager : MonoBehaviour {

	ArrayList recipes;
	ArrayList availableRecipes;
	public string[] ingredients;

	void Start () {
		this.recipes = new ArrayList ();
		this.availableRecipes = new ArrayList ();

		// Sample recipe - in real life we could load recipes via database or web call
		string[] ing_chickenStew = new string[] { "chicken", "water", "lettuce" };
		Recipe recipe_chickenStew = new Recipe ("Chicken Stew", "Hearty Chicken Stew", ing_chickenStew);
		this.recipes.Add (recipe_chickenStew);

		// This is assuming we can't get new cooking inventory items after this scene has started
		for (int i = 0; i < this.recipes.Count; i++) {
			Recipe r = (Recipe)this.recipes [i];
			if (r.isAvailable (this.ingredients)) {
				this.availableRecipes.Add (r);
				Debug.Log ("Adding recipe to availableRecipes: " + r.getName ());
			}
		}
	}
	
	void Update () {
		
	}
}
