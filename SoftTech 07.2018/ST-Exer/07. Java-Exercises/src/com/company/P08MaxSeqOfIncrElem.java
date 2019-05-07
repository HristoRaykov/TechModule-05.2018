package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class P08MaxSeqOfIncrElem {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		int[] arr = Arrays.stream(scanner.nextLine().split(" "))
				.mapToInt(Integer::parseInt)
				.toArray();
		
		int bestLen = 1;
		int len = 1;
		int bestIndex = 0;
		int index = 0;
		
		for (int i = 0; i < arr.length - 1; i++) {
			if (arr[i] < arr[i + 1]) {
				len++;
				if (len > bestLen) {
					bestLen = len;
					bestIndex = index;
				}
			} else {
				index = i + 1;
				len = 1;
			}
		}
		
		for (int i = bestIndex; i < bestIndex + bestLen; i++) {
			System.out.printf("%d ", arr[i]);
		}
	}
}
