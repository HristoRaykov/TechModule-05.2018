package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class P02Ladybugs {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int len = Integer.parseInt(scanner.nextLine());
		if (len<=0){
			return;
		}
		int[] bugs = new int[len];
		
		Arrays.stream(scanner.nextLine().split(" "))
				.mapToInt(Integer::parseInt)
				.filter(index -> index >= 0 && index < bugs.length)
				.forEach(index -> bugs[index] = 1);
		
		while (true) {
			String input = scanner.nextLine();
			if (input.equals("end")) {
				break;
			}
			String[] tokens = input.split(" ");
			int index = Integer.parseInt(tokens[0]);
			String direction = tokens[1];
			int length = Integer.parseInt(tokens[2]);
			
			performCommand(bugs, index, direction, length);
			
		}
		
		for (int element : bugs) {
			System.out.print(element+ " ");
		}
	}
	
	private static void performCommand(int[] bugs, int index, String direction, int length) {
		if (index < 0 || index >= bugs.length) {
			return;
		}
		if (bugs[index] != 1) {
			return;
		}
		bugs[index] = 0;
		int nextIndex = index;
		
		while (true) {
			if (direction.equals("right")) {
				nextIndex += length;
			} else if (direction.equals("left")) {
				nextIndex -= length;
			}
			
			if (nextIndex < 0 || nextIndex >= bugs.length) {
				break;
			} else {
				if (bugs[nextIndex] != 1) {
					bugs[nextIndex] = 1;
					break;
				}
			}
		}
		return;
	}
}
