using System;

namespace FizzBuzz
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			char input_char;

			label:

			Console.WriteLine ("===============FIZZBUZZ===============\n");
			Console.WriteLine ("Do you want to play FizzBuzz?");
			Console.WriteLine ("Press \"Y\" or \"N\" and press <enter>");

			input_char = Convert.ToChar (Console.ReadLine ());

			if (input_char == 'Y' || input_char == 'y') {
				FizzBuzz ();
				goto label;
			} else {
				Console.WriteLine("Thanks for playing!");
			}

		}

		public static void FizzBuzz() {
			const int UPPER_LIMIT = 100;

			for (int i = 1; i <= UPPER_LIMIT; i++) {
				if (i % 3 == 0 && i % 5 == 0) {
					Console.WriteLine ("FizzBuzz");
				} else if (i % 5 == 0) {
					Console.WriteLine ("Buzz");
				} else if (i % 3 == 0) {
					Console.WriteLine ("Fizz");
				} else {
					Console.Write (i);
					Console.Write ("\n");
				}
			}
		}
		
	}
}
