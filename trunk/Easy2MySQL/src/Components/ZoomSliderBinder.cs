
// ZoomSliderBinder.cs
//
using System;
using Easy2.Components;

namespace Easy2.Classes
{
	/// <summary>
	/// ZoomSliderBinder 클래스입니다.
	/// </summary>
	/// <remarks>
	/// 이 클래스는 SliderItemEx컨트롤과 QueryEditor 컨트롤의
	/// 줌인/줌아웃 /데이터바인딩을 위하여 만들어졌습니다.
	/// </remarks>
	public class ZoomSliderBinder : SliderItemEx
	{
		/// <summary>
		/// QueryEidtor의 Zoom값과 일치하도록 계산된 값을 나타냅니다.
		/// </summary>
		new public Int32 Value
		{
			get
			{
				if(base.Value < 0)
					return base.Value / 2;
				else
					return base.Value;
			}
			set
			{
				if(base.Value == value)
					return;

				if(value < 0)
					base.Value = value * 2;
				else
					base.Value = value;
			}
		}

		/// <summary>
		/// 계산되지 않은 값을 나타냅니다.
		/// </summary>
		public Int32 BaseValue
		{
			get { return base.Value; }
			set { base.Value = value; }
		}
	}
}
