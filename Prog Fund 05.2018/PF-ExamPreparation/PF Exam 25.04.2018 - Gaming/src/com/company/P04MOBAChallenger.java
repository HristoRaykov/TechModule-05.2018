package com.company;

import java.util.*;
import java.util.stream.Collectors;


public class P04MOBAChallenger {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);

		HashMap<String, HashMap<String, Integer>> players = new HashMap<>();

		while (true) {
			String line = scanner.nextLine();
			if (line.equals("Season end")) {
				break;
			}
			if (line.contains(" -> ")) {
				String[] tokens = line.split(" -> ");
				String playerName = tokens[0];
				String position = tokens[1];
				int skill = Integer.parseInt(tokens[2]);
				players.putIfAbsent(playerName, new HashMap<>());
				HashMap<String, Integer> positions = players.get(playerName);
				positions.putIfAbsent(position, skill);
				if (positions.get(position) < skill) {
					positions.replace(position, skill);
				}
			} else {
				String[] tokens = line.split(" vs ");
				String player1 = tokens[0];
				String player2 = tokens[1];
				if (players.containsKey(player1) && players.containsKey(player2)) {
					HashMap<String, Integer> player1Positions = players.get(player1);
					HashMap<String, Integer> player2Positions = players.get(player2);
					List<String> commons = new ArrayList<>(player1Positions.keySet());
					commons.retainAll(player2Positions.keySet());
					if (commons.size()>0) {
						int player1TotalSkill = player1Positions
								.entrySet()
								.stream()
								.mapToInt(e -> e.getValue())
								.sum();
						int player2TotalSkill = player2Positions
								.entrySet()
								.stream()
								.mapToInt(e -> e.getValue())
								.sum();

						if (player1TotalSkill > player2TotalSkill) {
							players.remove(player2);
						} else if (player1TotalSkill < player2TotalSkill) {
							players.remove(player1);
						}
					}
				}
			}
		}

		players
				.entrySet()
				.stream()
				.sorted((e1, e2) -> {
					int result = Integer.compare(
							e2.getValue().entrySet().stream().mapToInt(x -> x.getValue()).sum(),
							e1.getValue().entrySet().stream().mapToInt(x -> x.getValue()).sum()
					);
					if (result == 0) {
						e1.getKey().compareTo(e2.getKey());
					}
					return result;
				})
				.forEach(e -> {
					int totalSkillPoints = e.getValue().entrySet().stream().mapToInt(p -> p.getValue()).sum();
					System.out.println(e.getKey() + ": " + totalSkillPoints + " skill");
					e.getValue()
							.entrySet()
							.stream()
							.sorted((p1, p2) -> {
								int result = Integer.compare(p2.getValue(), p1.getValue());
								if (result == 0) {
									result = p1.getKey().compareTo(p2.getKey());
								}
								return result;
							})
							.forEach(p -> System.out.println("- " + p.getKey() + " <::> " + p.getValue()));
				});


		System.out.println();
	}
}
