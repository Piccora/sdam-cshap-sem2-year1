using System;

namespace PersonQueue {
	class Person {
		private string name;
		private int age;

		public string getName() {
			return name;
		}

		public int getAge() {
			return age;
		}

		public void setName(string name) {
			this.name = name;
		}

		public void setAge(int age) {
			this.age = age;
		}
	}
}
