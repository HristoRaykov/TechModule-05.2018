package com.company;

import javafx.util.Pair;

import java.util.ArrayList;
import java.util.LinkedHashMap;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Pattern;
import java.util.stream.Collectors;

public class P04PokemonEvolution {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		Pattern regex = Pattern.compile(" -> ");
		LinkedHashMap<String,List<Pair<String,Integer>>> pokemons = new LinkedHashMap<>();
		
		while (true){
		String line = scanner.nextLine();
		if (line.equals("wubbalubbadubdub")){
			break;
		}
		String[] tokens = regex.split(line);
		String name = tokens[0];
		if (tokens.length==1){
			if (pokemons.containsKey(name)){
				printPokemonByName(pokemons,name);
				continue;
			}else{
				continue;
			}
		}
		String type = tokens[1];
		int index = Integer.parseInt(tokens[2]);
		pokemons.putIfAbsent(name, new ArrayList<Pair<String, Integer>>());
		List<Pair<String,Integer>> types = pokemons.get(name);
		types.add(new Pair<>(type,index));
		pokemons.replace(name,types);
		}
		
		pokemons.entrySet()
				.stream()
				.forEach(e-> {
					List<Pair<String, Integer>> currentList =e.getValue()
							.stream()
							.sorted((p1,p2)-> Integer.compare(p2.getValue(),p1.getValue()))
							.collect(Collectors.toList());
					e.setValue(currentList);
					printPokemonByName(pokemons,e.getKey());
				});
		
		
		System.out.println();
	}
	
	private static void printPokemonByName(LinkedHashMap<String,List<Pair<String,Integer>>> pokemons ,String name) {
		System.out.println("# "+ name);
		for (Pair pair : pokemons.get(name)) {
			System.out.printf("%s <-> %d",pair.getKey(),pair.getValue());
			System.out.println();
		}
	}
}
