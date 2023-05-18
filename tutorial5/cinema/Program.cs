using System;

namespace PersonQueue {
	class Program {
		public static void Main(string[] args) {
			bool programLoop = true;
			PersonQueue cinemaQueue = new PersonQueue();
			while (programLoop) {
				try {
					Console.Write("Please enter your option: ");
					string option = Console.ReadLine();
					if (option == "J" || option == "j") {
						enqueuePerson(cinemaQueue);
					} else if (option == "L" || option == "l") {
						dequeuePerson(cinemaQueue);
					} else if (option == "E" || option == "e") {
						programLoop = false;
					} else {
						throw new Exception();
					}
				} catch (Exception ex) {
					Console.WriteLine("Please enter 'J' to queue a person, 'L' to dequeue a person, and 'E' to end the program.\n");
				}
			}
		}

		public static void enqueuePerson(PersonQueue queue) {
			bool enqueueLoop = true;
			while (enqueueLoop) {
				try {
					Console.Write("Please enter a name: ");
					string name = Console.ReadLine();
					Console.Write("Please enter the age: ");
					int age = Convert.ToInt32(Console.ReadLine());

					Person person = new Person();
					person.setName(name);
					person.setAge(age);
					queue.enqueue(person);

					Console.WriteLine("\nEnqueue completed!\n");
					enqueueLoop = false;
				} catch (Exception ex) {
					Console.WriteLine("Please enter a name and a valid age to enqueue the desired person.\n");
				}
			}
		}

		public static void dequeuePerson(PersonQueue queue) {
			if (queue.isEmpty()) {
				Console.WriteLine("There is no person to dequeue.\n");
				return;
			}
			Person person = queue.dequeue();
			if (person.getAge() >= 15) {
				Console.WriteLine(person.getName() + " has left the queue and has entered the cinema.\n");
			} else {
				Console.WriteLine(person.getName() + " has left the queue, but is too young to enter the cinema.\n");
			}
		}
	}
}
