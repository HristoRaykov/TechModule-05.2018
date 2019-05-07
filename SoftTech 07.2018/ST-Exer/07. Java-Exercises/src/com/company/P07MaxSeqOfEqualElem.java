package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class P07MaxSeqOfEqualElem {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		int[] arr = Arrays.stream(scanner.nextLine().split(" "))
				.mapToInt(Integer::parseInt)
				.toArray();
		
		int maxCount = 1;
		int count = 1;
		int startIndex = 0;
		int index = 0;
		
		for (int i = 0; i < arr.length - 1; i++) {
			if (arr[i] == arr[i + 1]) {
				count++;
				if (count > maxCount) {
					maxCount = count;
					startIndex = index;
				}
			} else {
				index = i + 1;
				count = 1;
			}
		}
		
		for (int i = 0; i < maxCount; i++) {
			System.out.printf("%d ",arr[startIndex]);
		}
	}
}
