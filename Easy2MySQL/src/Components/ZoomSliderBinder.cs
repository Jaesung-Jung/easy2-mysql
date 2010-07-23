
// ZoomSliderBinder.cs
//
using System;

namespace Easy2
{
	public class ZoomSliderBinder : SliderItemEx
	{
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

		public Int32 BaseValue
		{
			get { return base.Value; }
			set { base.Value = value; }
		}
	}
}
