package com.company;

import java.util.Scanner;
import java.util.TreeMap;

public class P19PhonebookUpgrade {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		TreeMap<String,String> phoneBook = new TreeMap<>();
		
		while (true){
			String input = scanner.nextLine();
			if (input.equals("END")){
				break;
			}
			if (input.equals("ListAll")){
				for (String contact : phoneBook.keySet()) {
					System.out.println(String.format("%s -> %s", contact, phoneBook.get(contact)));
				}
				continue;
			}
			String[] tokens = input.split(" ");
			String command = tokens[0];
			String name = "";
			String phoneNumber = "";
			if (command.equals("A")){
				name = tokens[1];
				phoneNumber = tokens[2];
				if (!phoneBook.containsKey(name)){
					phoneBook.put(name,"");
				}
				phoneBook.put(name,phoneNumber);
			}else if (command.equals("S")){
				name = tokens[1];
				if (phoneBook.containsKey(name)){
					System.out.println(String.format("%s -> %s", name, phoneBook.get(name)));
				}else{
					System.out.println(String.format("Contact %s does not exist.", name));
				}
			}
			
		}
		
		
	}
}
