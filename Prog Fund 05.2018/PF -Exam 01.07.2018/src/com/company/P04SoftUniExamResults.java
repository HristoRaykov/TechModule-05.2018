package com.company;

import java.util.HashMap;
import java.util.Scanner;

public class P04SoftUniExamResults {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		HashMap<String, Integer> results = new HashMap<>();
		HashMap<String, Integer> submissions = new HashMap<>();
		
		while (true) {
			String line = scanner.nextLine();
			if (line.equals("exam finished")) {
				break;
			}
			String[] tokens = line.split("-");
			String username = "";
			String language = "";
			int points = 0;
			if (tokens.length == 3) {
				username = tokens[0];
				language = tokens[1];
				points = Integer.parseInt(tokens[2]);
				
				results.putIfAbsent(username, points);
				if (points > results.get(username)) {
					results.replace(username, points);
				}
				submissions.putIfAbsent(language, 0);
				int submissionCount = submissions.get(language) + 1;
				submissions.replace(language, submissionCount);
				
			} else {
				username = tokens[0];
				results.remove(username);
			}
		}
		
		System.out.println("Results:");
		results
				.entrySet()
				.stream()
				.sorted((e1,e2)-> {
					int result = Integer.compare(e2.getValue(),e1.getValue());
					if (result==0){
						result = e1.getKey().compareTo(e2.getKey());
					}
					return result;
				})
				.forEach(e-> System.out.printf("%s | %d%n",e.getKey(),e.getValue()));
		
		
		System.out.println("Submissions:");
		submissions
				.entrySet()
				.stream()
				.sorted((e1,e2)-> {
					int result = Integer.compare(e2.getValue(),e1.getValue());
					if (result==0){
						result = e1.getKey().compareTo(e2.getKey());
					}
					return result;
				})
				.forEach(e-> System.out.printf("%s - %d%n",e.getKey(),e.getValue()));
		
		
	}
}
