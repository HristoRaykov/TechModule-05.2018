package com.company;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;


public class P12BombNumbers {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		List<Integer> nums = new ArrayList<>();
		
		Arrays.stream(scanner.nextLine().split(" "))
				.mapToInt(Integer::parseInt)
				.forEach(nums::add);
		String[] tokens = scanner.nextLine().split(" ");
		int specialNum = Integer.parseInt(tokens[0]);
		int power = Integer.parseInt(tokens[1]);
		
		while (true){
			int count = 0;
			for (int i = 0; i < nums.size(); i++) {
				if (nums.get(i) == specialNum){
					count++;
					detonate(nums,i,power);
				}
			}
			if (count==0){
				break;
			}
		}
		
		int sum = nums.stream().reduce(0, (x,y) -> x+y);
		System.out.println(sum);
	}
	
	private static void detonate(List<Integer> nums, int i, int power) {
		int startIndex = 0;
		int endIndex = nums.size();
		if (power<i){
			startIndex=i-power;
		}
		if (i+power<=nums.size()) {
			endIndex=i+power+1;
		}
		
		nums.subList(startIndex,endIndex).clear();
	}
	
	
}
