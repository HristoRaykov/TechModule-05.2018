package com.company;




import java.util.Scanner;

public class P04CharacterMultiplier {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String[] input = scanner.nextLine().split(" ");
		
		String str1 = input[0];
		String str2 = input[1];
		
		String longerStr = "";
		String shorterStr = "";
		if (str1.length() >= str2.length()) {
			longerStr = str1;
			shorterStr = str2;
		} else {
			longerStr = str2;
			shorterStr = str1;
		}
		int sum = 0;
		for (int i = 0; i < longerStr.length(); i++) {
			if (i<shorterStr.length()){
			sum+=shorterStr.charAt(i)*longerStr.charAt(i);
			}else{
				sum+=longerStr.charAt(i);
			}
			
		}
		System.out.println(sum);
	}
}
