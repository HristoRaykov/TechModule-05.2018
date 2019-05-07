package com.company;

import javafx.util.Pair;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;



public class P04Snowwhite {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);

		LinkedHashMap<String, LinkedHashMap<String, Integer>> dwarfNames = new LinkedHashMap<>();

		while (true) {
			String line = scanner.nextLine();
			if (line.equals("Once upon a time")) {
				break;
			}
			String[] tokens = line.split(" <:> ");
			String name = tokens[0];
			String color = tokens[1];
			int physics = Integer.parseInt(tokens[2]);

			dwarfNames.putIfAbsent(name, new LinkedHashMap<>());
			LinkedHashMap<String, Integer> colors = dwarfNames.get(name);
			colors.putIfAbsent(color, physics);
			if (colors.get(color) < physics) {
				colors.replace(color, physics);
			}
		}

		LinkedHashMap<Integer, String> namesByNumberKey = new LinkedHashMap<>();
		LinkedHashMap<Integer, Pair<String, Integer>> colorsByNumberKey = new LinkedHashMap<>();
		int keyNum = 1;
		for (Map.Entry<String, LinkedHashMap<String, Integer>> entry : dwarfNames.entrySet()) {
			for (Map.Entry<String, Integer> color : entry.getValue().entrySet()) {
				namesByNumberKey.putIfAbsent(keyNum, entry.getKey());
				colorsByNumberKey.putIfAbsent(keyNum, new Pair<>(color.getKey(), color.getValue()));
				keyNum++;
			}
		}

		LinkedHashMap<Integer, Pair<String, Integer>> sorted = new LinkedHashMap<>();
		 colorsByNumberKey
				.entrySet()
				.stream()
				.sorted((e1, e2) -> {
					int result = Integer.compare(e2.getValue().getValue(), e1.getValue().getValue());
					if (result == 0) {
						long c1 = colorsByNumberKey.entrySet().stream().filter(x -> x.getValue().getKey().equals(e1.getValue().getKey())).count();
						long c2 = colorsByNumberKey.entrySet().stream().filter(x -> x.getValue().getKey().equals(e2.getValue().getKey())).count();
						result = Long.compare(c2, c1);
					}
					return result;
				})
				.forEach(e->sorted.putIfAbsent(e.getKey(),e.getValue()));

		for (Map.Entry<Integer, Pair<String, Integer>> entry : sorted.entrySet()) {
					int key = entry.getKey();
					String color = entry.getValue().getKey();
					int skill = entry.getValue().getValue();
					String name = namesByNumberKey.get(key);
					System.out.printf("(%s) %s <-> %d", color, name, skill);
					System.out.println();
		}


//		stream solution
//		colorsByNumberKey
//				.entrySet()
//				.stream()
//				.sorted((e1, e2) -> {
//					int result = Integer.compare(e2.getValue().getValue(), e1.getValue().getValue());
//					if (result == 0) {
//						long c1 = colorsByNumberKey.entrySet().stream().filter(x -> x.getValue().getKey().equals(e1.getValue().getKey())).count();
//						long c2 = colorsByNumberKey.entrySet().stream().filter(x -> x.getValue().getKey().equals(e2.getValue().getKey())).count();
//						result = Long.compare(c2, c1);
//					}
//					return result;
//				})
//				.forEach(e -> {
//					int key = e.getKey();
//					String color = e.getValue().getKey();
//					int skill = e.getValue().getValue();
//					String name = namesByNumberKey.get(key);
//					System.out.printf("(%s) %s <-> %d", color, name, skill);
//					System.out.println();
//				});


		System.out.println();
	}
}
