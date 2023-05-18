using System;

namespace LibraryWithArrays {
	public class Member {
		private static int NextId = 1;
		private int id;
		public int Id {
			get {
				return id;
			}
			set {
				this.id = value;
			}
		}
		private string name;
		public string Name {
			get {
				return name;
			}
			set {
				this.name = value;
			}
		}

		public Member(string name) {
			this.Name = name;
			this.Id = NextId;
			NextId++;
		}

		public int GetID() {
			return Id;
		}

		public string GetName() {
			return Name;
		}
	}
}
