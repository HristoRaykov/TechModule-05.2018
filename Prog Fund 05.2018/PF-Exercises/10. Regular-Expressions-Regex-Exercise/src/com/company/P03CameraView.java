package com.company;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;


public class P03CameraView {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int[] tokens = Arrays.stream(scanner.nextLine().trim().split(" "))
				.mapToInt(Integer::parseInt)
				.toArray();
		int skip = tokens[0];
		int take = tokens[1];
		String text = scanner.nextLine();
		final String CAMERA = "\\|<";
		
		//solution with stream
		String[] split = text.split(CAMERA);
		List<String> splitted = new ArrayList<>();
		int index = text.indexOf("|<");
		if (index != 0) {
			for (int i = 1; i < split.length; i++) {
				String str = split[i];
				splitted.add(str);
			}
		} else {
			splitted = Arrays.asList(split);
		}
		splitted = splitted
				.stream()
				.filter(s -> s.length() > skip)
				.map(s -> {
					int startIndex = skip;
					int endIndex = s.length() < skip + take ? s.length(): skip + take;
					return s.substring(startIndex, endIndex);
				})
				.collect(Collectors.toList());
		
		System.out.println(String.join(", ",splitted));
		
		//solution without regex
//		List<String> result = new ArrayList<>();
//		int index = -1;
//		while (true) {
//			index = text.indexOf(CAMERA, index + 1);
//			int nextIndex = text.indexOf(CAMERA, index + 1);
//			if (index == -1) {
//				break;
//			}
//			if (nextIndex == -1) {
//				nextIndex = text.length();
//			}
//			int startIndex = index + skip + 2;
//			int endIndex = startIndex + take;
//			if (nextIndex >= endIndex) {
//				String view = text.substring(startIndex, endIndex);
//				result.add(view);
//			}else if (startIndex < nextIndex && nextIndex < endIndex) {
//				String view = text.substring(startIndex,nextIndex);
//				result.add(view);
//			}
//		}
//
//		System.out.println(String.join(", ",result));
	}
}
