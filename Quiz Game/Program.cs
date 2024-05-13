using System;

namespace Quiz_Game
{
	internal class Program
	{
		public static string[] questions = {
			"What is the capital of France?",
			"What is 2 + 2?",
			"Who wrote 'Hamlet'?",
			"What is the chemical symbol for water?",
			"What is the tallest mammal?",
			"Who painted the Mona Lisa?",
			"What is the currency of Japan?",
			"What is the largest planet in our solar system?",
			"What year did World War I begin?",
			"What is the primary language spoken in Brazil?"
		};
		public static string[] answers = {
			"Paris",
			"4",
			"Shakespeare",
			"H2O",
			"Giraffe",
			"Leonardo da Vinci",
			"Yen",
			"Jupiter",
			"1914",
			"Portuguese"
		};
		static void Main(string[] args)
		{


			Console.WriteLine("Welcome to the Game :) ");
			Console.WriteLine("Please answer the folliwing question :)\n ");


			int NumbersQuestion;
			do
			{
				Console.Write("How many questions do you want today? ");

			} while (!int.TryParse(Console.ReadLine(), out NumbersQuestion) || NumbersQuestion > 10);

			int score = 0;
			Random random = new Random();

			List<int> usedIndices = new List<int>();

			int randomIndex;

			for (int i = 0; i < NumbersQuestion; i++)

			{

				do
				{
					randomIndex = random.Next(0, questions.Length);


				} while (usedIndices.Contains(randomIndex));

				usedIndices.Add(randomIndex);

				Console.WriteLine($"question {i + 1} --- >\t {questions[randomIndex]}\n");
				Console.Write("Your answer: ");


				string answer = Console.ReadLine();

				if (string.IsNullOrEmpty(answer))
				{
					Console.WriteLine("invalid answer");
				}

				bool Result = Isanswer(answer, answers[randomIndex]);

				if (Result == true)
				{
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("Correct!");
					Console.ForegroundColor = ConsoleColor.White;
					score++;
				}

			}

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"You got {score} out of {NumbersQuestion} correct!");
			Console.ForegroundColor = ConsoleColor.White;

		}
		private static bool Isanswer(string InswerInput ,string Inswer)
		{


			if (Inswer.ToLower() == InswerInput.ToLower())
				return true;


			return false;
		}
	}
}
