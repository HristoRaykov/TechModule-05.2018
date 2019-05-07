package com.company;

import javafx.util.Pair;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;


public class P02Snowmen {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String[] tokens = scanner.nextLine().split("\\s+");
		List<Pair<Integer, Boolean>> snowmen = new ArrayList<>();
		for (String token : tokens) {
			snowmen.add(new Pair(Integer.parseInt(token), false));
		}
		
		while (snowmen.size() > 1) {
			for (int i = 0; i < snowmen.size(); i++) {
				int attackerIndex = i;
				if (snowmen.get(attackerIndex).getValue() == true) {
					continue;
				}
				int targetIndex = snowmen.get(i).getKey();
				if (targetIndex >= snowmen.size()) {
					targetIndex = targetIndex % snowmen.size();
				}
				
				long aliveSnowmenCount = snowmen
						.stream()
						.filter(e -> e.getValue() == false)
						.count();
				if (aliveSnowmenCount==1){
					break;
				}
				
				int diff = Math.abs(attackerIndex - targetIndex);
				
				if (diff == 0) {
					snowmen.set(attackerIndex, new Pair<>(snowmen.get(attackerIndex).getKey(), true));
					System.out.println(attackerIndex + " performed harakiri");
				} else {
					if (diff % 2 == 0) {
						snowmen.set(targetIndex, new Pair<>(snowmen.get(targetIndex).getKey(), true));
						System.out.printf("%d x %d -> %d wins", attackerIndex, targetIndex, attackerIndex);
						System.out.println();
					} else {
						snowmen.set(attackerIndex, new Pair<>(snowmen.get(attackerIndex).getKey(), true));
						System.out.printf("%d x %d -> %d wins", attackerIndex, targetIndex, targetIndex);
						System.out.println();
					}
				}
			}
			snowmen = snowmen
					.stream()
					.filter(e -> e.getValue() == false)
					.collect(Collectors.toList());
			
		}
		
	}
}
