package com.company;

import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.*;

public class P25BookLibraryModification {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		int n =Integer.parseInt(scanner.nextLine());
		DateTimeFormatter dateFormatter =DateTimeFormatter.ofPattern("dd.MM.yyyy");
		Library library = new Library();
		Map<String,Double> authors = new HashMap<>();
		
		for (int i = 0; i < n; i++) {
			String[] tokens = scanner.nextLine().split(" ");
			String title = tokens[0];
			String author = tokens[1];
			String publisher = tokens[2];
			LocalDate date = LocalDate.parse(tokens[3],dateFormatter);
			String isbnNumber = tokens[4];
			double price = Double.parseDouble(tokens[5]);
			
			Book book = new Book(title,author,publisher,date,isbnNumber,price);
			library.addBook(book);
		}
		
		LocalDate releaseDate = LocalDate.parse(scanner.nextLine(),dateFormatter);
		
		library.getBooks().stream()
				.filter(book -> book.getDate().isAfter(releaseDate))
				.sorted((b1,b2)->{
					int result = b1.getDate().compareTo(b2.getDate());
					if (result == 0 ){
						result= b1.getTitle().compareTo(b2.getTitle());
					}
					return result;
				})
				.forEach(book-> System.out.println(String.format("%s -> %s",book.getTitle(),book.getDate().format(dateFormatter))));
		
		
		
		System.out.println();
	}
}

