
// TooltipManager.cs
//
using System.Drawing;
using System.ComponentModel;
using DevComponents.DotNetBar;

namespace Easy2.Classes
{
	/// <summary>
	/// 컴포넌트들의 툴팁을 관리하는 매니저입니다.
	/// </summary>
	public class TooltipManager
	{
		/// <summary>
		/// 인스턴스를 생성하고 초기화합니다.
		/// </summary>
		public TooltipManager()
		{
			this.m_manager = new SuperTooltip();
		}

		/// <summary>
		/// 컴포넌트에 툴팁을 지정합니다.
		/// </summary>
		/// <param name="c">대상 컴포넌트입니다.</param>
		/// <param name="header">머릿글입니다.</param>
		/// <param name="body">본문입니다.</param>
		/// <param name="footer">바닥글입니다.</param>
		/// <param name="color">배경색입니다.</param>
		/// <param name="bodyImg">본문이미지입니다.</param>
		/// <param name="footerImg">바닥이미지입니다.</param>
		public void SetTooltip(IComponent c, string header, string body, string footer, eTooltipColor color, Image bodyImg, Image footerImg)
		{
			this.m_manager.SetSuperTooltip(c, new SuperTooltipInfo(header, footer, body, bodyImg, footerImg, color));
		}

		private SuperTooltip m_manager;
	}
}
