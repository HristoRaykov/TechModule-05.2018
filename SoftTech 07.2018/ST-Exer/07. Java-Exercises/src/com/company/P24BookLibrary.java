package com.company;

import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.*;

public class P24BookLibrary {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		int n = Integer.parseInt(scanner.nextLine());
		DateTimeFormatter dateFormatter = DateTimeFormatter.ofPattern("dd.MM.yyyy");
		Library library = new Library();
		Map<String, Double> authors = new HashMap<>();
		
		for (int i = 0; i < n; i++) {
			String[] tokens = scanner.nextLine().split(" ");
			String title = tokens[0];
			String author = tokens[1];
			String publisher = tokens[2];
			LocalDate date = LocalDate.parse(tokens[3], dateFormatter);
			String isbnNumber = tokens[4];
			double price = Double.parseDouble(tokens[5]);
			
			Book book = new Book(title, author, publisher, date, isbnNumber, price);
			library.addBook(book);
		}
		
		for (Book book : library.getBooks()) {
			if (!authors.containsKey(book.getAuthor())) {
				authors.put(book.getAuthor(), 0.0);
			}
			authors.put(book.getAuthor(), authors.get(book.getAuthor()) + book.getPrice());
		}
		
		authors.entrySet().stream()
				.sorted((e1, e2) -> {
					int result = Double.compare(e2.getValue(), e1.getValue());
					if (result == 0.0) {
						result = e1.getKey().compareTo(e2.getKey());
					}
					return result;
				})
				.forEach(e -> System.out.println(String.format("%s -> %.2f", e.getKey(), e.getValue())));
		
		System.out.println();
	}
}

class Book {
	private String title;
	
	private String author;
	
	private String publisher;
	
	private LocalDate date;
	
	private String isbnNumber;
	
	private double price;
	
	public Book(String title, String author, String publisher, LocalDate date, String isbnNumber, double price) {
		this.title = title;
		this.author = author;
		this.publisher = publisher;
		this.date = date;
		this.isbnNumber = isbnNumber;
		this.price = price;
	}
	
	
	public String getTitle() {
		return title;
	}
	
	public String getAuthor() {
		return author;
	}
	
	public String getPublisher() {
		return publisher;
	}
	
	public LocalDate getDate() {
		return date;
	}
	
	public String getIsbnNumber() {
		return isbnNumber;
	}
	
	public double getPrice() {
		return price;
	}
}

class Library {
	private String name;
	
	private List<Book> books = new ArrayList<>();
	
	public String getName() {
		return name;
	}
	
	public void setName(String name) {
		this.name = name;
	}
	
	public List<Book> getBooks() {
		return books;
	}
	
	public void setBooks(List<Book> books) {
		this.books = books;
	}
	
	public void addBook(Book book) {
		this.books.add(book);
	}
}