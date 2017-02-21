using System;
using System.Collections.Generic;

namespace SJB.ZAR.WPF.Model
	{
	public class Dropzone
		{
		private String id;
		private String name;
		private Boolean isWater;
		private Boolean common;
		private Boolean activerecord;
		private DropzoneType type;

		public String ID
			{
			get { return id; }
			set { id = value; }
			}

		public String Name
			{
			get { return name; }
			set { name = value; }
			}

		public Boolean CommonUse
			{
			get { return common; }
			set { common = value; }
			}

		public Boolean ActiveRecord
			{
			get { return activerecord; }
			set { activerecord = value; }
			}

		public DropzoneType Type
			{
			get { return type; }
			set { type = value; }
			}

		public Dropzone()
			{
			this.id = "ID Not Set";
			this.name = "Name Not Set";
			this.common = true;
			this.activerecord = true;
			}

		public Dropzone(String id, String name, Boolean common)
			{
			this.id = id;
			this.name = name;
			this.common = common;
			this.activerecord = true;
			}
			
		}
	}
