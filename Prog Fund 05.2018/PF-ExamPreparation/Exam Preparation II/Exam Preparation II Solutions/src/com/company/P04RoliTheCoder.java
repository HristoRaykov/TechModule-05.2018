package com.company;

import javafx.util.Pair;

import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import java.util.stream.Collectors;

public class P04RoliTheCoder {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		Pattern participantsPattern = Pattern.compile("(?<=@)[A-Za-z0-9\\'\\-]*");

		Map<String, Pair<String, List<String>>> idMap = new LinkedHashMap<>();

		while (true) {
			String line = scanner.nextLine();
			if (line.equals("Time for Code")) {
				break;
			}
			String[] tokens1 = line.split("#");
			if (tokens1.length != 2) {
				continue;
			}
			String id = tokens1[0].trim();
			String[] tokens2 = tokens1[1].trim().split("@");
			String eventName = tokens2[0].trim();
			Matcher matcher = participantsPattern.matcher(line);
			List<String> participantsName = new ArrayList<>();
			while (matcher.find()) {
				participantsName.add(matcher.group());
			}

			if (idMap.containsKey(id) == false) {
				idMap.put(id, new Pair<>(eventName, participantsName));
			} else {
				Pair<String, List<String>> eventPair = idMap.get(id);
				if (eventPair.getKey().equals(eventName)) {
					participantsName.addAll(eventPair.getValue());
					idMap.replace(id, new Pair<>(eventName, participantsName));
				}
			}
		}

		idMap
				.entrySet()
				.stream()
				.forEach(entry -> {
					List<String> sorted = entry.getValue().getValue()
							.stream()
							.distinct()
							.sorted(String::compareToIgnoreCase)
							.collect(Collectors.toList());
					entry.setValue(new Pair<>(entry.getValue().getKey(), sorted));
				});
		idMap
				.entrySet()
				.stream()
				.sorted((e1,e2)->{
					int result = Integer.compare(e2.getValue().getValue().size(),e1.getValue().getValue().size());
					if (result==0){
						result = e1.getValue().getKey().compareToIgnoreCase(e2.getValue().getKey());
					}
					return result;
				})
				.forEach(entry -> {
					System.out.printf("%s - %d",entry.getValue().getKey(),entry.getValue().getValue().size());
					System.out.println();
					entry
							.getValue()
							.getValue()
							.stream()
							.forEach(str-> System.out.println("@"+str));
				});

	}
}
