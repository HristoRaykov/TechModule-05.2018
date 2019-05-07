package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class P11EqualSums {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		int[] arr = Arrays.stream(scanner.nextLine().split(" "))
				.mapToInt(Integer::parseInt)
				.toArray();
		
		boolean hasSuchSum = false;
		int totalSum = Arrays.stream(arr).sum();
		int leftSum = 0;
		int rightSum = 0;
		int index = 0;
		
		for (int i = 0; i < arr.length; i++) {
			leftSum = Arrays.stream(arr)
					.limit(i)
					.sum();
			rightSum = totalSum - leftSum - arr[i];
			if (leftSum==rightSum){
				index = i;
				hasSuchSum = true;
			}
		}
		
		if (hasSuchSum){
			System.out.println(index);
		}else {
			System.out.println("no");
		}
	}
}
