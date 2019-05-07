package com.company;

import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;


public class P05MagicExchangeableWords {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[] line = input.nextLine().split(" ");
		String shorterStr = line[0].length() > line[1].length() ? line[1] : line[0];
		String longerStr = line[0].length() <= line[1].length() ? line[1] : line[0];
		
		LinkedHashMap<Character, Character> dict = new LinkedHashMap<>();
		boolean isExchangeable = true;
		
		for (int i = 0; i < shorterStr.length(); i++) {
			char key = shorterStr.charAt(i);
			
			if (!dict.containsKey(key)) {
				dict.put(key, longerStr.charAt(i));
			} else {
				if (!dict.get(key).equals(longerStr.charAt(i))) {
					isExchangeable = false;
					break;
				}
			}
		}
		
		for (int i = shorterStr.length(); i < longerStr.length(); i++) {
			char value = longerStr.charAt(i);
			if (!dict.containsValue(value)) {
				isExchangeable = false;
				break;
			}
		}
		int distinctSize = dict
				.entrySet()
				.stream()
				.map(Map.Entry::getValue)
				.distinct()
				.toArray()
				.length;
		
		
		if (distinctSize!=dict.size()) {
			isExchangeable = false;
		}
		
		if (isExchangeable) {
			System.out.println("true");
		} else {
			System.out.println("false");
		}
		
	}
}
