package com.company;

import java.util.*;
import java.util.stream.Collectors;

public class P07QueryMess {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String input;
		LinkedHashMap<String, List<String>> pairs = new LinkedHashMap<>();


		while (true) {
			pairs.clear();
			input = scanner.nextLine();
			if (input.equals("END")) {
				break;
			}
			input = input.replaceAll("\\+", " ");
			input = input.replaceAll("%20", " ");
			List<String> result = Arrays.stream(input.split("(\\&|\\?)"))
					.filter(s -> s.contains("="))
					.map(s -> s.replaceAll("\\s+", " "))
					.collect(Collectors.toList());
			for (String str : result) {
				String[] tokens = str.split("\\=");
				String key = tokens[0].trim();
				String value = tokens[1].trim();
				if (pairs.containsKey(key) == false) {
					pairs.put(key, new ArrayList<>());
				}
				pairs.get(key).add(value);
			}

			for (Map.Entry<String, List<String>> entry : pairs.entrySet()) {
				System.out.printf("%s=[%s]",entry.getKey(),String.join(", ",entry.getValue()));
			}
			System.out.println();
		}


		System.out.println();
	}
}
