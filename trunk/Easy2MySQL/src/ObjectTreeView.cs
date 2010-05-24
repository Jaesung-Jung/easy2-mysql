
// ObjectTreeView.cs
//
using System.ComponentModel;
using DevComponents.AdvTree;

namespace Easy2
{
	/// <summary>
	/// 오브젝트 트리 뷰 클래스입니다.
	/// </summary>
	class ObjectTreeView : AdvTree
	{
	}

	enum ObjectType
	{
		Connection,
		Database,
		Tables,
		Views,
		StoredProcs,
		Functions,
		Triggers,
		Events,
		Columns,
		Indexes,
	}
}