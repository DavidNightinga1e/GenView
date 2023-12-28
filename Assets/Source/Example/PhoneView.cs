// Warning: This file is code-generated
// Modifying it can lead to data-loss
// ------------------------------------
// Generated using GenView by David Nightingale
// https://github.com/DavidNightinga1e

// ReSharper disable InconsistentNaming

namespace GenView.Example
{
	public class PhoneView : GenView.Core.GeneratedView
	{
		[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
		public UnityEngine.RectTransform RectTransform => _rectTransform;

		[UnityEngine.SerializeField] private GenView.Core.ViewGenerationAssistant _viewGenerationAssistant;
		public GenView.Core.ViewGenerationAssistant ViewGenerationAssistant => _viewGenerationAssistant;

		[UnityEngine.SerializeField] private PhoneView_Background _background;
		public PhoneView_Background Background => _background;

		[UnityEngine.SerializeField] private PhoneView_Display _display;
		public PhoneView_Display Display => _display;

		[UnityEngine.SerializeField] private PhoneView_KeypadContainer _keypadContainer;
		public PhoneView_KeypadContainer KeypadContainer => _keypadContainer;

		[System.Serializable]
		public class PhoneView_Background
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private UnityEngine.CanvasRenderer _canvasRenderer;
			public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer;

			[UnityEngine.SerializeField] private UnityEngine.UI.Image _image;
			public UnityEngine.UI.Image Image => _image;
		}

		[System.Serializable]
		public class PhoneView_Display
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private PhoneView_Display_Background _background;
			public PhoneView_Display_Background Background => _background;

			[UnityEngine.SerializeField] private PhoneView_Display_Text _text;
			public PhoneView_Display_Text Text => _text;
		}

		[System.Serializable]
		public class PhoneView_Display_Background
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private UnityEngine.CanvasRenderer _canvasRenderer;
			public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer;

			[UnityEngine.SerializeField] private UnityEngine.UI.Image _image;
			public UnityEngine.UI.Image Image => _image;
		}

		[System.Serializable]
		public class PhoneView_Display_Text
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private UnityEngine.CanvasRenderer _canvasRenderer;
			public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer;

			[UnityEngine.SerializeField] private UnityEngine.UI.Text _text;
			public UnityEngine.UI.Text Text => _text;
		}

		[System.Serializable]
		public class PhoneView_KeypadContainer
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private PhoneView_KeypadContainer_Grid _grid;
			public PhoneView_KeypadContainer_Grid Grid => _grid;
		}

		[System.Serializable]
		public class PhoneView_KeypadContainer_Grid
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private UnityEngine.UI.GridLayoutGroup _gridLayoutGroup;
			public UnityEngine.UI.GridLayoutGroup GridLayoutGroup => _gridLayoutGroup;

			[UnityEngine.SerializeField] private PhoneView_KeypadContainer_Grid_Button1 _button1;
			public PhoneView_KeypadContainer_Grid_Button1 Button1 => _button1;

			[UnityEngine.SerializeField] private PhoneView_KeypadContainer_Grid_Button2 _button2;
			public PhoneView_KeypadContainer_Grid_Button2 Button2 => _button2;

			[UnityEngine.SerializeField] private PhoneView_KeypadContainer_Grid_Button3 _button3;
			public PhoneView_KeypadContainer_Grid_Button3 Button3 => _button3;

			[UnityEngine.SerializeField] private PhoneView_KeypadContainer_Grid_Button4 _button4;
			public PhoneView_KeypadContainer_Grid_Button4 Button4 => _button4;

			[UnityEngine.SerializeField] private PhoneView_KeypadContainer_Grid_Button5 _button5;
			public PhoneView_KeypadContainer_Grid_Button5 Button5 => _button5;

			[UnityEngine.SerializeField] private PhoneView_KeypadContainer_Grid_Button6 _button6;
			public PhoneView_KeypadContainer_Grid_Button6 Button6 => _button6;

			[UnityEngine.SerializeField] private PhoneView_KeypadContainer_Grid_Button7 _button7;
			public PhoneView_KeypadContainer_Grid_Button7 Button7 => _button7;

			[UnityEngine.SerializeField] private PhoneView_KeypadContainer_Grid_Button8 _button8;
			public PhoneView_KeypadContainer_Grid_Button8 Button8 => _button8;

			[UnityEngine.SerializeField] private PhoneView_KeypadContainer_Grid_Button9 _button9;
			public PhoneView_KeypadContainer_Grid_Button9 Button9 => _button9;

			[UnityEngine.SerializeField] private PhoneView_KeypadContainer_Grid_Button_star _button_star;
			public PhoneView_KeypadContainer_Grid_Button_star Button_star => _button_star;

			[UnityEngine.SerializeField] private PhoneView_KeypadContainer_Grid_Button_0 _button_0;
			public PhoneView_KeypadContainer_Grid_Button_0 Button_0 => _button_0;

			[UnityEngine.SerializeField] private PhoneView_KeypadContainer_Grid_Button_sharp _button_sharp;
			public PhoneView_KeypadContainer_Grid_Button_sharp Button_sharp => _button_sharp;
		}

		[System.Serializable]
		public class PhoneView_KeypadContainer_Grid_Button1
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private UnityEngine.CanvasRenderer _canvasRenderer;
			public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer;

			[UnityEngine.SerializeField] private UnityEngine.UI.Image _image;
			public UnityEngine.UI.Image Image => _image;

			[UnityEngine.SerializeField] private UnityEngine.UI.Button _button;
			public UnityEngine.UI.Button Button => _button;

			[UnityEngine.SerializeField] private PhoneView_KeypadContainer_Grid_Button1_Text _text;
			public PhoneView_KeypadContainer_Grid_Button1_Text Text => _text;
		}

		[System.Serializable]
		public class PhoneView_KeypadContainer_Grid_Button1_Text
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private UnityEngine.CanvasRenderer _canvasRenderer;
			public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer;

			[UnityEngine.SerializeField] private UnityEngine.UI.Text _text;
			public UnityEngine.UI.Text Text => _text;
		}

		[System.Serializable]
		public class PhoneView_KeypadContainer_Grid_Button2
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private UnityEngine.CanvasRenderer _canvasRenderer;
			public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer;

			[UnityEngine.SerializeField] private UnityEngine.UI.Image _image;
			public UnityEngine.UI.Image Image => _image;

			[UnityEngine.SerializeField] private UnityEngine.UI.Button _button;
			public UnityEngine.UI.Button Button => _button;

			[UnityEngine.SerializeField] private PhoneView_KeypadContainer_Grid_Button2_Text _text;
			public PhoneView_KeypadContainer_Grid_Button2_Text Text => _text;
		}

		[System.Serializable]
		public class PhoneView_KeypadContainer_Grid_Button2_Text
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private UnityEngine.CanvasRenderer _canvasRenderer;
			public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer;

			[UnityEngine.SerializeField] private UnityEngine.UI.Text _text;
			public UnityEngine.UI.Text Text => _text;
		}

		[System.Serializable]
		public class PhoneView_KeypadContainer_Grid_Button3
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private UnityEngine.CanvasRenderer _canvasRenderer;
			public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer;

			[UnityEngine.SerializeField] private UnityEngine.UI.Image _image;
			public UnityEngine.UI.Image Image => _image;

			[UnityEngine.SerializeField] private UnityEngine.UI.Button _button;
			public UnityEngine.UI.Button Button => _button;

			[UnityEngine.SerializeField] private PhoneView_KeypadContainer_Grid_Button3_Text _text;
			public PhoneView_KeypadContainer_Grid_Button3_Text Text => _text;
		}

		[System.Serializable]
		public class PhoneView_KeypadContainer_Grid_Button3_Text
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private UnityEngine.CanvasRenderer _canvasRenderer;
			public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer;

			[UnityEngine.SerializeField] private UnityEngine.UI.Text _text;
			public UnityEngine.UI.Text Text => _text;
		}

		[System.Serializable]
		public class PhoneView_KeypadContainer_Grid_Button4
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private UnityEngine.CanvasRenderer _canvasRenderer;
			public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer;

			[UnityEngine.SerializeField] private UnityEngine.UI.Image _image;
			public UnityEngine.UI.Image Image => _image;

			[UnityEngine.SerializeField] private UnityEngine.UI.Button _button;
			public UnityEngine.UI.Button Button => _button;

			[UnityEngine.SerializeField] private PhoneView_KeypadContainer_Grid_Button4_Text _text;
			public PhoneView_KeypadContainer_Grid_Button4_Text Text => _text;
		}

		[System.Serializable]
		public class PhoneView_KeypadContainer_Grid_Button4_Text
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private UnityEngine.CanvasRenderer _canvasRenderer;
			public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer;

			[UnityEngine.SerializeField] private UnityEngine.UI.Text _text;
			public UnityEngine.UI.Text Text => _text;
		}

		[System.Serializable]
		public class PhoneView_KeypadContainer_Grid_Button5
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private UnityEngine.CanvasRenderer _canvasRenderer;
			public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer;

			[UnityEngine.SerializeField] private UnityEngine.UI.Image _image;
			public UnityEngine.UI.Image Image => _image;

			[UnityEngine.SerializeField] private UnityEngine.UI.Button _button;
			public UnityEngine.UI.Button Button => _button;

			[UnityEngine.SerializeField] private PhoneView_KeypadContainer_Grid_Button5_Text _text;
			public PhoneView_KeypadContainer_Grid_Button5_Text Text => _text;
		}

		[System.Serializable]
		public class PhoneView_KeypadContainer_Grid_Button5_Text
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private UnityEngine.CanvasRenderer _canvasRenderer;
			public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer;

			[UnityEngine.SerializeField] private UnityEngine.UI.Text _text;
			public UnityEngine.UI.Text Text => _text;
		}

		[System.Serializable]
		public class PhoneView_KeypadContainer_Grid_Button6
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private UnityEngine.CanvasRenderer _canvasRenderer;
			public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer;

			[UnityEngine.SerializeField] private UnityEngine.UI.Image _image;
			public UnityEngine.UI.Image Image => _image;

			[UnityEngine.SerializeField] private UnityEngine.UI.Button _button;
			public UnityEngine.UI.Button Button => _button;

			[UnityEngine.SerializeField] private PhoneView_KeypadContainer_Grid_Button6_Text _text;
			public PhoneView_KeypadContainer_Grid_Button6_Text Text => _text;
		}

		[System.Serializable]
		public class PhoneView_KeypadContainer_Grid_Button6_Text
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private UnityEngine.CanvasRenderer _canvasRenderer;
			public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer;

			[UnityEngine.SerializeField] private UnityEngine.UI.Text _text;
			public UnityEngine.UI.Text Text => _text;
		}

		[System.Serializable]
		public class PhoneView_KeypadContainer_Grid_Button7
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private UnityEngine.CanvasRenderer _canvasRenderer;
			public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer;

			[UnityEngine.SerializeField] private UnityEngine.UI.Image _image;
			public UnityEngine.UI.Image Image => _image;

			[UnityEngine.SerializeField] private UnityEngine.UI.Button _button;
			public UnityEngine.UI.Button Button => _button;

			[UnityEngine.SerializeField] private PhoneView_KeypadContainer_Grid_Button7_Text _text;
			public PhoneView_KeypadContainer_Grid_Button7_Text Text => _text;
		}

		[System.Serializable]
		public class PhoneView_KeypadContainer_Grid_Button7_Text
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private UnityEngine.CanvasRenderer _canvasRenderer;
			public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer;

			[UnityEngine.SerializeField] private UnityEngine.UI.Text _text;
			public UnityEngine.UI.Text Text => _text;
		}

		[System.Serializable]
		public class PhoneView_KeypadContainer_Grid_Button8
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private UnityEngine.CanvasRenderer _canvasRenderer;
			public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer;

			[UnityEngine.SerializeField] private UnityEngine.UI.Image _image;
			public UnityEngine.UI.Image Image => _image;

			[UnityEngine.SerializeField] private UnityEngine.UI.Button _button;
			public UnityEngine.UI.Button Button => _button;

			[UnityEngine.SerializeField] private PhoneView_KeypadContainer_Grid_Button8_Text _text;
			public PhoneView_KeypadContainer_Grid_Button8_Text Text => _text;
		}

		[System.Serializable]
		public class PhoneView_KeypadContainer_Grid_Button8_Text
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private UnityEngine.CanvasRenderer _canvasRenderer;
			public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer;

			[UnityEngine.SerializeField] private UnityEngine.UI.Text _text;
			public UnityEngine.UI.Text Text => _text;
		}

		[System.Serializable]
		public class PhoneView_KeypadContainer_Grid_Button9
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private UnityEngine.CanvasRenderer _canvasRenderer;
			public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer;

			[UnityEngine.SerializeField] private UnityEngine.UI.Image _image;
			public UnityEngine.UI.Image Image => _image;

			[UnityEngine.SerializeField] private UnityEngine.UI.Button _button;
			public UnityEngine.UI.Button Button => _button;

			[UnityEngine.SerializeField] private PhoneView_KeypadContainer_Grid_Button9_Text _text;
			public PhoneView_KeypadContainer_Grid_Button9_Text Text => _text;
		}

		[System.Serializable]
		public class PhoneView_KeypadContainer_Grid_Button9_Text
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private UnityEngine.CanvasRenderer _canvasRenderer;
			public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer;

			[UnityEngine.SerializeField] private UnityEngine.UI.Text _text;
			public UnityEngine.UI.Text Text => _text;
		}

		[System.Serializable]
		public class PhoneView_KeypadContainer_Grid_Button_star
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private UnityEngine.CanvasRenderer _canvasRenderer;
			public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer;

			[UnityEngine.SerializeField] private UnityEngine.UI.Image _image;
			public UnityEngine.UI.Image Image => _image;

			[UnityEngine.SerializeField] private UnityEngine.UI.Button _button;
			public UnityEngine.UI.Button Button => _button;

			[UnityEngine.SerializeField] private PhoneView_KeypadContainer_Grid_Button_star_Text _text;
			public PhoneView_KeypadContainer_Grid_Button_star_Text Text => _text;
		}

		[System.Serializable]
		public class PhoneView_KeypadContainer_Grid_Button_star_Text
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private UnityEngine.CanvasRenderer _canvasRenderer;
			public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer;

			[UnityEngine.SerializeField] private UnityEngine.UI.Text _text;
			public UnityEngine.UI.Text Text => _text;
		}

		[System.Serializable]
		public class PhoneView_KeypadContainer_Grid_Button_0
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private UnityEngine.CanvasRenderer _canvasRenderer;
			public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer;

			[UnityEngine.SerializeField] private UnityEngine.UI.Image _image;
			public UnityEngine.UI.Image Image => _image;

			[UnityEngine.SerializeField] private UnityEngine.UI.Button _button;
			public UnityEngine.UI.Button Button => _button;

			[UnityEngine.SerializeField] private PhoneView_KeypadContainer_Grid_Button_0_Text _text;
			public PhoneView_KeypadContainer_Grid_Button_0_Text Text => _text;
		}

		[System.Serializable]
		public class PhoneView_KeypadContainer_Grid_Button_0_Text
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private UnityEngine.CanvasRenderer _canvasRenderer;
			public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer;

			[UnityEngine.SerializeField] private UnityEngine.UI.Text _text;
			public UnityEngine.UI.Text Text => _text;
		}

		[System.Serializable]
		public class PhoneView_KeypadContainer_Grid_Button_sharp
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private UnityEngine.CanvasRenderer _canvasRenderer;
			public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer;

			[UnityEngine.SerializeField] private UnityEngine.UI.Image _image;
			public UnityEngine.UI.Image Image => _image;

			[UnityEngine.SerializeField] private UnityEngine.UI.Button _button;
			public UnityEngine.UI.Button Button => _button;

			[UnityEngine.SerializeField] private PhoneView_KeypadContainer_Grid_Button_sharp_Text _text;
			public PhoneView_KeypadContainer_Grid_Button_sharp_Text Text => _text;
		}

		[System.Serializable]
		public class PhoneView_KeypadContainer_Grid_Button_sharp_Text
		{
			[UnityEngine.SerializeField] private UnityEngine.RectTransform _rectTransform;
			public UnityEngine.RectTransform RectTransform => _rectTransform;

			[UnityEngine.SerializeField] private UnityEngine.CanvasRenderer _canvasRenderer;
			public UnityEngine.CanvasRenderer CanvasRenderer => _canvasRenderer;

			[UnityEngine.SerializeField] private UnityEngine.UI.Text _text;
			public UnityEngine.UI.Text Text => _text;
		}
	}
}
