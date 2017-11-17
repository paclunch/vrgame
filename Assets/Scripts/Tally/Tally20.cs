using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tally20 : MonoBehaviour {
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
	public bool finished = true;


	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (juiceBox.correct == true && dinosaurChickenNuggets.correct == true) {
			SceneManager.LoadScene ("Menu_Win");	
			finished = true;
		}
		if (flintstonesThermos.wrong + scoobyDooThermos.wrong + babyCarrots.wrong + macAndCheese.wrong + chipsAhoy.wrong + ritzBitz.wrong + oreos.wrong + goldfish.wrong + orange.wrong + lunchables.wrong + candy.wrong + sandwich.wrong + soup.wrong + milkCarton.wrong + dinosaurChickenNuggets.wrong + stringCheese.wrong + chips.wrong + juiceBox.wrong + mickeyFriendsThermos.wrong + powerRangersThermos.wrong + disneyPrincessThermos.wrong + helloKittyThermos.wrong + lizzieMcGuireThermos.wrong + peanutsThermos.wrong + apple.wrong + brownie.wrong + grapes.wrong == 3) {
			SceneManager.LoadScene ("Menu_Lose");
		}
	}

}
