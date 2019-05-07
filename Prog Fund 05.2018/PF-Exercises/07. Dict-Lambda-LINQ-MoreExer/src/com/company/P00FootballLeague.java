package com.company;

import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class P00FootballLeague {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String key = scanner.nextLine();
		String keyRegex = "(?<=" + Pattern.quote(key) + ")[A-Za-z]*(?=" + Pattern.quote(key) + ")";
		String resultRegex = "\\d+:\\d+$";
		Pattern teamNamePatter = Pattern.compile(keyRegex);
		Pattern resultPattern = Pattern.compile(resultRegex);

		LinkedHashMap<String, int[]> table = new LinkedHashMap<String, int[]>();

		while (true) {
			String line = scanner.nextLine();
			if (line.equals("final")) {
				break;
			}
			String team1 = "";
			String team2 = "";
			Matcher nameMatcher = teamNamePatter.matcher(line);
			if (nameMatcher.find()) {
				team1 = new StringBuilder(nameMatcher.group().toUpperCase()).reverse().toString();
			}
			if (nameMatcher.find()) {
				team2 = new StringBuilder(nameMatcher.group().toUpperCase()).reverse().toString();
			}

			Matcher resultMatcher = resultPattern.matcher(line);
			String[] result = new String[2];
			if (resultMatcher.find()) {
				result = resultMatcher.group().trim().split(":");
			}
			int team1Goals = Integer.parseInt(result[0]);
			int team2Goals = Integer.parseInt(result[1]);
			int team1Points = 0;
			int team2Points = 0;
			if (team1Goals == team2Goals) {
				team1Points = 1;
				team2Points = 1;
			} else {
				team1Points = team1Goals > team2Goals ? 3 : 0;
				team2Points = team2Goals > team1Goals ? 3 : 0;
			}

			table.putIfAbsent(team1, new int[2]);
			team1Points += table.get(team1)[0];
			team1Goals += table.get(team1)[1];
			int[] dataTeam1 = new int[]{team1Points, team1Goals};
			table.replace(team1, dataTeam1);

			table.putIfAbsent(team2, new int[2]);
			team2Points += table.get(team2)[0];
			team2Goals += table.get(team2)[1];
			int[] dataTeam2 = new int[]{team2Points, team2Goals};
			table.replace(team2, dataTeam2);
		}
		LinkedHashMap<String, int[]> sorted = new LinkedHashMap<>();
		table.entrySet()
				.stream()
				.sorted((e1, e2) -> {
					int result = Integer.compare(e2.getValue()[0], e1.getValue()[0]);
					if (result == 0) {
						result = e1.getKey().compareTo(e2.getKey());
					}
					return result;
				})
				.forEach(entry -> sorted.put(entry.getKey(), entry.getValue()));


		System.out.println("League standings:");
		int couter = 1;
		for (Map.Entry<String, int[]> entry : sorted.entrySet()) {
			System.out.printf("%d. %s %d", couter++, entry.getKey(), entry.getValue()[0]);
			System.out.println();
		}
		System.out.println("Top 3 scored goals:");
		table.entrySet()
				.stream()
				.sorted((e1, e2) -> {
					int result = Integer.compare(e2.getValue()[1], e1.getValue()[1]);
					if (result == 0) {
						result = e1.getKey().compareTo(e2.getKey());
					}
					return result;
				})
				.limit(3)
				.forEach(e -> {
					System.out.printf("- %s -> %d", e.getKey(),e.getValue()[1]);
					System.out.println();
				});

		System.out.println();
	}
}
