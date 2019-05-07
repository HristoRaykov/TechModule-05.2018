package com.company;

import java.io.IOException;
import java.io.PrintStream;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.HashMap;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class P03WordCount {
	public static void main(String[] args) throws IOException {
		String text = new String(Files.readAllBytes(Paths.get("resources-and-results/03. Word Count/text.txt")));
		String[] words = new String(Files.readAllBytes(Paths.get("resources-and-results/03. Word Count/words.txt")))
				.split(" ");
		PrintStream writer = new PrintStream("resources-and-results/03. Word Count/result.txt");
		
		HashMap<String, Integer> wordsMap = new HashMap<>();
		for (String word : words) {
			int count = getOccurrences(text, word);
			wordsMap.putIfAbsent(word, count);
		}
		wordsMap
				.entrySet()
				.stream()
				.sorted((o1, o2) -> Integer.compare(o2.getValue(), o1.getValue()))
				.forEach(entry -> writer.printf("%s - %d%n", entry.getKey(), entry.getValue()));
		
		
	}
	
	private static int getOccurrences(String text, String word) {
		int count = 0;
		String regex = "(?<=\\W)"+Pattern.quote(word.toLowerCase())+"(?=\\W)";
		Matcher matcher = Pattern.compile(regex).matcher(text.toLowerCase());
		while (matcher.find()) {
			count++;
		}
		return count;
	}
}
