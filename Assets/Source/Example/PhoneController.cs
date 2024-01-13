using System;
using UnityEngine;

namespace GenView.Example
{
	public class PhoneController : MonoBehaviour
	{
		[SerializeField]
		private PhoneView view;

		private void Awake()
		{
			var keypad = view.KeypadContainer.Grid;
			
			view.Display.Text.Text.text = String.Empty;

			view.KeypadContainer.Grid.Button2.Image.color = Color.red;

			keypad.Button1.Text.Text.text = "1";
			keypad.Button2.Text.Text.text = "2";
			keypad.Button3.Text.Text.text = "3";
			keypad.Button4.Text.Text.text = "4";
			keypad.Button5.Text.Text.text = "5";
			keypad.Button6.Text.Text.text = "6";
			keypad.Button7.Text.Text.text = "7";
			keypad.Button8.Text.Text.text = "8";
			keypad.Button9.Text.Text.text = "9";
			keypad.Button_sharp.Text.Text.text = "#";
			keypad.Button_star.Text.Text.text = "*";
			keypad.Button_0.Text.Text.text = "0";
			
			keypad.Button1.Button.onClick.AddListener(() => ButtonClicked("1"));
			keypad.Button2.Button.onClick.AddListener(() => ButtonClicked("2"));
			keypad.Button3.Button.onClick.AddListener(() => ButtonClicked("3"));
			keypad.Button4.Button.onClick.AddListener(() => ButtonClicked("4"));
			keypad.Button5.Button.onClick.AddListener(() => ButtonClicked("5"));
			keypad.Button6.Button.onClick.AddListener(() => ButtonClicked("6"));
			keypad.Button7.Button.onClick.AddListener(() => ButtonClicked("7"));
			keypad.Button8.Button.onClick.AddListener(() => ButtonClicked("8"));
			keypad.Button9.Button.onClick.AddListener(() => ButtonClicked("9"));
			keypad.Button_star.Button.onClick.AddListener(() => ButtonClicked("*"));
			keypad.Button_0.Button.onClick.AddListener(() => ButtonClicked("0"));
			keypad.Button_sharp.Button.onClick.AddListener(() => ButtonClicked("#"));
		}

		private void ButtonClicked(string text)
		{
			view.Display.Text.Text.text += text;
		}
	}
}