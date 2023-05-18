using System;
using System.Collections.Generic;

namespace PersonQueue {
	class PersonQueue {
		private List<Person> queue;

		public PersonQueue() {
			this.queue = new List<Person>();
		}

		public Person dequeue() {
			try {
				Person temp = queue[0];
				this.queue.RemoveAt(0);
				return temp;
			}
			catch (ArgumentOutOfRangeException) {
				throw new Exception("Cannot dequeue when queue is empty");
			}
		}

		public void enqueue(Person p) {
			this.queue.Add(p);
		}

		public bool isEmpty() {
			return queue.Count == 0;
		}
	}
}
