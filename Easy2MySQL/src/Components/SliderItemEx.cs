
// SliderItemEx.cs
//
using System;
using System.ComponentModel;
using DevComponents.DotNetBar;

namespace Easy2
{
	/// <summary>
	/// 슬라이더의 Step의 값을 좌우로 구분할 수 있는 새로운 클래스입니다.
	/// </summary>
	public class SliderItemEx : SliderItem
	{
		/// <summary>
		/// OnValueChanging 재정의입니다.
		/// </summary>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnValueChanging(CancelIntValueEventArgs e)
		{
			base.OnValueChanging(e);

			if(e.NewValue > this.Maximum || e.NewValue < this.Minimum)
				return;

			this.m_value = 0;

			// 기준값 = 최소값 + (최대값 - 최소값) / 2
			int criteria = this.Minimum + (this.Maximum - this.Minimum) / 2;

			// 왼쪽 이동
			if(e.NewValue < criteria && this.Step != this.m_lStep)
			{
				this.Step = this.m_lStep;
				m_value = this.Value - this.m_lStep;
			}
			// 오른쪽 이동
			else if(e.NewValue > criteria && this.Step != this.m_rStep)
			{
				this.Step = this.m_rStep;
				m_value = this.Value + this.m_rStep;
			}
			else
			{
				this.m_value = e.NewValue;
			}
		}

		/// <summary>
		/// OnValueChanged 재정의입니다.
		/// </summary>
		protected override void OnValueChanged()
		{
			base.OnValueChanged();
			if(this.Value != this.m_value)
 			{
 				this.Value = this.m_value;
 			}
		}

		[Browsable(true)]
		[DefaultValue(1)]
		[Description("슬라이더가 왼쪽으로 이동할 때의 이동수치입니다.")]
		[Category("Behavior")]
		public Int32 LeftStep
		{
			get { return this.m_lStep; }
			set { this.m_lStep = value; }
		}

		[Browsable(true)]
		[DefaultValue(1)]
		[Description("슬라이더가 오른쪽으로 이동할 때의 이동수치입니다.")]
		[Category("Behavior")]
		public Int32 RightStep
		{
			get { return this.m_rStep; }
			set { this.m_rStep = value; }
		}

		private Int32 m_lStep = 1;
		private Int32 m_rStep = 1;
		private int m_value;
	}
}
