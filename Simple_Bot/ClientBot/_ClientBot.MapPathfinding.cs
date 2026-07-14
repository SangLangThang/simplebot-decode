using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class _ClientBot
	{
		private List<TreeNode> FlattenMapTree(TreeNode root)
		{
			List<TreeNode> list = new List<TreeNode>();
			FlattenMapTreeInto(root, list);
			return list;
		}

		private void FlattenMapTreeInto(TreeNode root, List<TreeNode> nodes)
		{
			nodes.Add(root);
			foreach (TreeNode child in root.Nodes)
			{
				nodes.Add(child);
				FlattenMapTreeInto(child, nodes);
			}
		}

		public void AutoWarp(string idmap)
		{
			string text = Conversions.ToString(Data_Player._MapId);
			checked
			{
				if ((Operators.CompareString(text, idmap, false) != 0) & (BTQ == 0))
				{
					listWarp.Clear();
					foreach (TreeNode item in FlattenMapTree(TreeView1.Nodes[0]))
					{
						TreeNode treeNode = item;
						if (Operators.CompareString(treeNode.Name, text, false) != 0)
						{
							continue;
						}
						listStart.Clear();
						while (treeNode.Parent != null)
						{
							if (treeNode.Parent != null)
							{
								listStart.Add(treeNode.Name);
								treeNode = treeNode.Parent;
							}
						}
						listStart.Add(TreeView1.Nodes[0].Name);
						break;
					}
					if (!listStart.Contains(idmap))
					{
						foreach (TreeNode item2 in FlattenMapTree(TreeView1.Nodes[0]))
						{
							TreeNode treeNode2 = item2;
							if (Operators.CompareString(treeNode2.Name, idmap, false) != 0)
							{
								continue;
							}
							listEnd.Clear();
							while (treeNode2.Parent != null)
							{
								if (treeNode2.Parent != null)
								{
									if (!listEnd.Contains(treeNode2.Name))
									{
										listEnd.Add(treeNode2.Name);
										treeNode2 = treeNode2.Parent;
									}
									else if (listEnd.Contains(treeNode2.Name))
									{
										break;
									}
								}
							}
							listEnd.Add(TreeView1.Nodes[0].Name);
							break;
						}
						foreach (object item3 in listStart)
						{
							string value = Conversions.ToString(item3);
							listWarp.Add(value);
							if (listEnd.IndexOf(value) > 0)
							{
								int num = listEnd.IndexOf(value) - 1;
								for (int i = num; i >= 0; i += -1)
								{
									listWarp.Add(RuntimeHelpers.GetObjectValue(listEnd[i]));
								}
								break;
							}
						}
					}
					else if (listStart.Contains(idmap))
					{
						foreach (object item4 in listStart)
						{
							string text2 = Conversions.ToString(item4);
							listWarp.Add(text2);
							if (Operators.CompareString(text2, idmap, false) == 0)
							{
								break;
							}
						}
					}
					if (Operators.CompareString(GetMapIdNext(listWarp, Data_Player._MapId.ToString()), AutoWarptoMap, false) == 0)
					{
						int warpID = GetWarpID(Data_Player._MapId.ToString(), GetMapIdNext(listWarp, Data_Player._MapId.ToString()));
						if (warpID > 0)
						{
							Warp(warpID);
							return;
						}
						listWarp.Clear();
						atw = 0;
					}
					else if (Operators.CompareString(GetMapIdNext(listWarp, Data_Player._MapId.ToString()), AutoWarptoMap, false) != 0)
					{
						int warpID2 = GetWarpID(Data_Player._MapId.ToString(), GetMapIdNext(listWarp, Data_Player._MapId.ToString()));
						if (warpID2 > 0)
						{
							Warp(warpID2);
							return;
						}
						listWarp.Clear();
						atw = 0;
					}
				}
				else
				{
					listWarp.Clear();
					atw = 0;
				}
			}
		}

		public static string GetMapIdNext(ArrayList listmap, string mapid)
		{
			string result = "00000";
			checked
			{
				if (listmap.Contains(mapid))
				{
					int num = listmap.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(listmap[i], mapid, false), i < listmap.Count - 1)))
						{
							result = Conversions.ToString(listmap[i + 1]);
							break;
						}
					}
				}
				return result;
			}
		}

		public int GetWarpID(string mapid1, string mapid2)
		{
			int result = 0;
			Doors.Key_Door key = new Doors.Key_Door
			{
				_MapId1 = Conversions.ToInteger(mapid1),
				_MapId2 = Conversions.ToInteger(mapid2)
			};
			if (Doors.Data_Doors.ContainsKey(key))
			{
				result = Doors.Data_Doors[key];
			}
			return result;
		}
	}
}
