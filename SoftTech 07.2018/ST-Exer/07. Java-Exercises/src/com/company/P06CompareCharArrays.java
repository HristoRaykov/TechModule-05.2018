package com.company;

import java.util.Scanner;

public class P06CompareCharArrays {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		String str1= String.join("",scanner.nextLine().split(" "));
		String str2= String.join("",scanner.nextLine().split(" "));
		
		if (str1.compareTo(str2)<=0){
			System.out.println(str1);
			System.out.println(str2);
		}else {
			System.out.println(str2);
			System.out.println(str1);
		}
		
		
	}
}
