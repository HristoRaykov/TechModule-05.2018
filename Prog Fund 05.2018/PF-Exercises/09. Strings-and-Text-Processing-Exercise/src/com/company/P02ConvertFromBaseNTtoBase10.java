package com.company;

import java.math.BigInteger;
import java.util.Scanner;

public class P02ConvertFromBaseNTtoBase10 {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[] tokens = input.nextLine().split(" ");

		int baseN = Integer.parseInt(tokens[0]);
		String baseNnumber = tokens[1];
		BigInteger number = ConverTo10Base(baseNnumber, baseN);


		System.out.println(number);
	}

	private static BigInteger ConverTo10Base(String baseNnumber, int baseN) {
		BigInteger result = new BigInteger("0");
		BigInteger secondNum = new BigInteger("1");
		for (int i = baseNnumber.length() - 1; i >= 0; i--) {
			BigInteger firstNum = new BigInteger(String.valueOf(baseNnumber.charAt(i)));
			result = result.add(firstNum.multiply(secondNum));
			secondNum = secondNum.multiply(new BigInteger(String.valueOf(baseN)));
		}
		return result;
	}

}
