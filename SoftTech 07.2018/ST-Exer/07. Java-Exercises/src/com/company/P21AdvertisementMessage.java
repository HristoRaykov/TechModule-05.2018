package com.company;

import java.util.Random;
import java.util.Scanner;

public class P21AdvertisementMessage {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		int n = Integer.parseInt(scanner.nextLine());
		
		String[] phrases = new String[]{"Excellent product.", "Such a great product.",
				"I always use that product.", "Best product of its category.",
				"Exceptional product.", "I can't live without this product."};
		String[] events = new String[]{"Now I feel good.", "I have succeeded with this product.",
				"Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
				"Try it yourself, I am very satisfied.", "I feel great!"};
		String[] authors = new String[]{"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
		String[] cities = new String[]{"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};
		
		Random random = new Random();
		int phraseIndex = 0;
		int eventIndex = 0;
		int authorIndex = 0;
		int cityIndex = 0;
		
		for (int i = 0; i < n; i++) {
			phraseIndex = random.nextInt(phrases.length);
			eventIndex = random.nextInt(events.length);
			authorIndex = random.nextInt(authors.length);
			cityIndex = random.nextInt(cities.length);
			System.out.println(String.format("%s %s %s - %s",
					phrases[phraseIndex], events[eventIndex], authors[authorIndex], cities[cityIndex]));
		}
	}
}
