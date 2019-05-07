package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class P09MostFrequentNumber {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		int[] arr = Arrays.stream(scanner.nextLine().split(" "))
				.mapToInt(Integer::parseInt)
				.toArray();
		boolean[] isChecked = new boolean[arr.length];
		
		
		int maxCount = 1;
		int bestNum = arr[0];
		int count = 1;
		
		for (int i = 0; i < arr.length - 1; i++) {
			if (isChecked[i]){
				continue;
			}
			int currNum = arr[i];
			for (int j = i+1; j < arr.length; j++) {
				if (isChecked[j]) {
					continue;
				}
				if (currNum == arr[j]) {
					isChecked[j] = true;
					count++;
					if (count > maxCount) {
						maxCount = count;
						bestNum = currNum;
					}
				} else {
					count = 1;
				}
			}
			
		}
		
		System.out.println(bestNum);
	}
}
