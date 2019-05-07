package com.company;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Pattern;

public class P02KaminoFactory {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int len = Integer.parseInt(scanner.nextLine());
		Pattern pattern = Pattern.compile("\\!+");
		List<int[]> array = new ArrayList<>();
		int maxLength = 0;
		int bestIndex = Integer.MAX_VALUE;
		int maxSum = Integer.MAX_VALUE;
		int rowNumber = 0;
		int counter = 0;

		while (true) {
			String line = scanner.nextLine();
			if (line.equals("Clone them!")) {
				break;
			}
			int[] input = Arrays.stream(pattern.split(line))
					.mapToInt(Integer::parseInt)
					.toArray();

			array.add(input);

			int[] currentData = GetMaxSequence(input);
			int length = currentData[0];
			int index = currentData[1];
			int sum = currentData[2];

			if (maxLength < length) {
				maxLength = length;
				bestIndex = index;
				maxSum = sum;
				rowNumber = counter;
			} else if (maxLength == length) {
				if (bestIndex > index) {
					bestIndex = index;
					maxSum = sum;
					rowNumber = counter;
				} else if (bestIndex == index) {
					if (maxSum < sum) {
						maxSum = sum;
						rowNumber = counter;
					}
				}
			}
			counter++;
		}


		System.out.printf("Best DNA sample %d with sum: %d.%n", rowNumber + 1, maxSum);
		int[] result = array.get(rowNumber);
		for (int i = 0; i < result.length; i++) {
			if (i == result.length - 1) {
				System.out.print(result[i]);
			} else {
				System.out.print(result[i] + " ");
			}
		}


	}

	private static int[] GetMaxSequence(int[] input) {
		int sum = 0;
		int index = 0;
		int maxLength = 0;
		int currLength = 0;
		for (int i = 0; i < input.length; i++) {
			if (input[i] == 1) {
				sum++;
				currLength++;
			}
			if (maxLength < currLength) {
				maxLength = currLength;
				index = i + 1 - currLength;
			}
			if (input[i] == 0) {

				currLength = 0;
			}
		}
		int[] result = new int[3];
		result[0] = maxLength;
		result[1] = index;
		result[2] = sum;
		return result;
	}
}
