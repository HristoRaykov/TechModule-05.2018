package com.company;

import java.util.Scanner;

public class P09MelrahShake {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		StringBuilder text = new StringBuilder(input.nextLine());
		StringBuilder pattern = new StringBuilder(input.nextLine());

		while (true) {
			int firstIndex = text.indexOf(String.valueOf(pattern));
			int lastIndex = text.lastIndexOf(String.valueOf(pattern));
			if (firstIndex == -1 || lastIndex == -1 || firstIndex == lastIndex) {
				System.out.println("No shake.");
				System.out.println(text);
				break;
			}
			int firstMatchEndIndex = firstIndex + pattern.length();
			text.delete(firstIndex, firstMatchEndIndex);

			lastIndex = text.lastIndexOf(String.valueOf(pattern));
			int lastMatchEndIndex = lastIndex + pattern.length();
			text.delete(lastIndex, lastMatchEndIndex);

			System.out.println("Shaked it.");
			pattern.deleteCharAt(pattern.length() / 2);
			if (pattern.length()==0){
				System.out.println("No shake.");
				System.out.println(text);
				break;
			}

		}

	}
}
