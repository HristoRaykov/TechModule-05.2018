package com.company;

import java.util.Scanner;

public class P16URLParser {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		String url = scanner.nextLine();
		String protocol = "";
		String secondPart = "";
		String server = "";
		String resource = "";
		
		
		if (url.contains("://")) {
			protocol = url.split("://")[0];
			secondPart = url.split("://")[1];
			if (secondPart.contains("/")) {
				server = secondPart.split("/", 2)[0];
				resource = secondPart.split("/", 2)[1];
			} else {
				server = secondPart;
			}
		} else {
			if (url.contains("/")) {
				server = url.split("/", 2)[0];
				resource = url.split("/", 2)[1];
			} else {
				server = url;
			}
		}
		
		System.out.printf("[protocol] = \"%s\"%n", protocol);
		System.out.printf("[server] = \"%s\"%n", server);
		System.out.printf("[resource] = \"%s\"%n", resource);
		
	}
}
