package com.company;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class P02ExtractSentencesByKeyword {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String word = scanner.nextLine().trim();
		String text = scanner.nextLine();
		
		//String sentenceRegex = "[A-Z].+?[\\.!?]";
		String splitRegex = "[.?!]";
		String wordRegex = "\\W"+word+"\\W";
		
		Pattern pattern = Pattern.compile(wordRegex);

		Arrays.stream(text.split(splitRegex))
				.filter(s -> pattern.matcher(s).find())
				.map(String::trim)
				.forEach(System.out::println);
		
		
		
//		List<String> result = new ArrayList<>();
//		String[] sentences = text.split(splitRegex);
//		for (String sentence : sentences) {
//			Matcher matcher = pattern.matcher(sentence);
//			if (matcher.find()) {
//				result.add(sentence.trim());
//			}
//		}
//		System.out.println(String.join(System.lineSeparator(),result));
		System.out.println();
	}
}
