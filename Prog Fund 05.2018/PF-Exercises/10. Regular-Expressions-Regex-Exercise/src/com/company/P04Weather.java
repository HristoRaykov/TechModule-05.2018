package com.company;

import javafx.util.Pair;

import java.util.*;
import java.util.function.Function;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import java.util.stream.Collector;
import java.util.stream.Collectors;
import java.util.stream.Stream;

public class P04Weather {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String dataRegex = "[A-Z]{2}\\d+\\.\\d+[A-Za-z]+(?=\\|)";
		Pattern dataPattern = Pattern.compile(dataRegex);
		String doubleRegex = "\\d+\\.\\d+";
		Pattern doublePattern = Pattern.compile(doubleRegex);

		LinkedHashMap<String, String[]> weatherForcast = new LinkedHashMap<>();
//
		while (true) {
			String input = scanner.nextLine();
			if (input.equals("end")) {
				break;
			}
			Matcher dataMatcher = dataPattern.matcher(input);
			if (dataMatcher.find() == false) {
				continue;
			}
			String data = dataMatcher.group();
			String[] tokens = data.split(doubleRegex);
			String city = tokens[0];
			String weather = tokens[1];

			Matcher doublematcher = doublePattern.matcher(data);
			boolean hasMatch = doublematcher.find();
			String averageTemp = "";
			if (hasMatch) {
				averageTemp = doublematcher.group();
			}

			if (weatherForcast.containsKey(city) == false) {
				weatherForcast.put(city, new String[2]);
			}
			weatherForcast.get(city)[0] = averageTemp;
			weatherForcast.get(city)[1] = weather;
		}

		weatherForcast
				.entrySet()
				.stream()
				.sorted((e1, e2) -> e1.getValue()[0].compareTo(e2.getValue()[0]))
				.forEach(e -> {
					String city = e.getKey();
					String weather = e.getValue()[1];
					double averageTemp = Double.parseDouble(e.getValue()[0]);
					System.out.printf("%s => %.2f => %s", city,averageTemp,weather);
					System.out.println();
				});
//				.collect(Collectors.toMap(Map.Entry::getKey, Map.Entry::getValue,
//						(e1, e2) -> e1, LinkedHashMap::new));

		System.out.println();
	}
}



