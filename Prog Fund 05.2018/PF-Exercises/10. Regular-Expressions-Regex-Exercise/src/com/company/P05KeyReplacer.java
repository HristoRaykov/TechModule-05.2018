package com.company;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class P05KeyReplacer {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String key = scanner.nextLine();
		String text = scanner.nextLine();
		String startKey = "";
		String endKey = "";

		String startKeyRegex = "^[A-Za-z]+(?=(<|\\\\|\\|))";
		Matcher matcherStartKey = Pattern.compile(startKeyRegex).matcher(key);
		String endKeyRegex = "(?<=(<|\\\\|\\|))[A-Za-z]+$";
		Matcher matcherEndKey = Pattern.compile(endKeyRegex).matcher(key);
		if (matcherStartKey.find() && matcherEndKey.find()){
			startKey = matcherStartKey.group();
			endKey = matcherEndKey.group();
		}

		String keyRegex = startKey+"(.*?)"+endKey;
		Matcher matcherKey = Pattern.compile(keyRegex).matcher(text);
		List<String> result = new ArrayList<>();
		while (matcherKey.find()){
			result.add(matcherKey.group(1));
		}

		if (result.isEmpty()){
			System.out.println("Empty result");
		}else{
		System.out.println(String.join("",result));
		}
	}
}
