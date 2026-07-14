using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Simple_Bot
{
	public partial class frmClient : Form
	{
		public struct Trangbi_Info
		{
			public int _stt;

			public int _id;

			public int _doben;

			public PictureBox _photo;
		}

		public struct Tuido_Info
		{
			public int _stt;

			public int _id;

			public int _count;

			public Label _photo;
		}

		public struct Tuideo_Info
		{
			public int _stt;

			public int _id;

			public int _count;

			public Label _photo;
		}

		public struct _QuestStep
		{
			public string _Func;

			public int _id;

			public int _index;
		}

		public _ClientBot _bot;

		public Bitmap _map;

		public Dictionary<int, Trangbi_Info> Data_Trangbi_Char;

		public Dictionary<int, Trangbi_Info> Data_Trangbi_Pet;

		public Dictionary<int, Tuido_Info> Data_Tuido;

		public Dictionary<int, Tuideo_Info> Data_Tuideo;

		public Dictionary<int, ComboBoxItem> List_skill_char;

		public Dictionary<int, ComboBoxItem> List_skill_pet;

		private Label _draggedTuidoLabel;

		// Declared but never referenced anywhere in the original decompiled source.
		private Label aek;

		private Label ael;

		public int tooltip_check;

		public int _Tuideo_slot_select;

		public int _Homdo_slot_select;

		public Label label_selected;

		public int r_Id_rtbsystem;

		public int r_Id_rtbChat;

		public int r_Id_rtbQuest;

		public int _petSelect;

		public List<string> _list_Func;

		private ArrayList _questSteps;

		private int _questStepIndex;

		public _ClientBot _Botting
		{
			get
			{
				if (_bot != null)
				{
					return _bot;
				}
				_ClientBot result = default(_ClientBot);
				return result;
			}
			set
			{
				_bot = value;
			}
		}
	}
}
