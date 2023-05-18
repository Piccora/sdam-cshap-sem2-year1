using System;

namespace PersonQueue {
	class Program {
		public static void Main(string[] args) {
			PersonQueue queue = new PersonQueue();

			Person person1 = new Person();
			person1.setName("Henry");

			Person person2 = new Person();
			person2.setName("Jack");

			Person person3 = new Person();
			person3.setName("Eliza");

			queue.enqueue(person1);
			queue.enqueue(person2);
			queue.enqueue(person3);

			while (!queue.isEmpty()) {
				Console.WriteLine(queue.dequeue().getName());
			}
		}
	}
}
