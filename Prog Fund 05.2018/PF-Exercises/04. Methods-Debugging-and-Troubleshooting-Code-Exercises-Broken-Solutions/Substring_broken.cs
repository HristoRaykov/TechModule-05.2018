using System;

public class Substring_broken
{
	public static void Main()
	{
		string text = Console.ReadLine();
		int count = int.Parse(Console.ReadLine());

		const char charToFind = 'р';
		bool hasMatch = false;

		for (int i = 0; i < text.Length; i++)
		{
			if (text[i] == charToFind)
			{
				hasMatch = true;

				int endIndex = i + count;

				if (endIndex > text.Length)
				{
					endIndex = text.Length;
				}

				string matchedString = text.Substring(i, count);
				Console.WriteLine(matchedString);
				i += count;
			}
		}

		if (!hasMatch)
		{
			Console.WriteLine("no");
		}
	}
}
