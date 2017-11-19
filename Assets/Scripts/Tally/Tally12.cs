using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tally12 : MonoBehaviour {
	public Flinstones_Thermos flintstonesThermos;
	public Scooby_Doo_Thermos scoobyDooThermos;
	public Baby_Carrots babyCarrots;
	public Mac_Cheese macAndCheese;
	public Chips_Ahoy chipsAhoy;
	public Ritz_Bitz ritzBitz;
	public Oreos oreos;
	public Goldfish goldfish;
	public Orange orange;
	public Lunchables lunchables;
	public Candy candy;
	public Sandwich sandwich;
	public Soup soup;
	public Milk_Carton milkCarton;
	public Dinosaur_Chicken_Nuggets dinosaurChickenNuggets;
	public String_Cheese stringCheese;
	public Chips chips;
	public Juice_Box juiceBox;
	public Mickey_Friends_Thermos mickeyFriendsThermos;
	public Power_Rangers_Thermos powerRangersThermos;
	public Disney_Princess_Thermos disneyPrincessThermos;
	public Hello_Kitty_Thermos helloKittyThermos;
	public Lizzie_McGuire_Thermos lizzieMcGuireThermos;
	public Peanuts_Thermos peanutsThermos;
	public Apple apple;
	public Brownie brownie;
	public Grapes grapes;
	public bool finished = false;
	public bool failed = false;


	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (chips.selected == 1 && juiceBox.selected == 1 && disneyPrincessThermos.selected == 1 && brownie.selected == 1 && soup.selected == 1) {
			SceneManager.LoadScene ("Scene13");	
			finished = true;
		}
		if (flintstonesThermos.selected + scoobyDooThermos.selected + babyCarrots.selected + macAndCheese.selected + chipsAhoy.selected + ritzBitz.selected + oreos.selected + goldfish.selected + orange.selected + lunchables.selected + candy.selected + sandwich.selected + milkCarton.selected + dinosaurChickenNuggets.selected + stringCheese.selected + mickeyFriendsThermos.selected + powerRangersThermos.selected + helloKittyThermos.selected + lizzieMcGuireThermos.selected + peanutsThermos.selected + apple.selected + grapes.selected == 3) {
			SceneManager.LoadScene ("Menu_Lose");
			failed = true;
		}
	}

}
