package com.company;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class P02PokemonDontGo {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		List<Integer> pokemons = Arrays.stream(scanner.nextLine().split(" "))
				.map(Integer::parseInt)
				.collect(Collectors.toList());
		long sum = 0;

		while (pokemons.isEmpty()==false) {
			int index = Integer.parseInt(scanner.nextLine());
			int element = 0;
			if (index<0){
				element = pokemons.get(0);
				pokemons.set(0,pokemons.get(pokemons.size()-1));
			}else if (index>pokemons.size()-1){
				element = pokemons.get(pokemons.size()-1);
				pokemons.set(pokemons.size()-1,pokemons.get(0));
			}else {
				element = pokemons.get(index);
				pokemons.remove(index);
			}

			sum += element;
			int finalElement = element;
			pokemons= pokemons
					.stream()
					.map(e -> {
						if (e<= finalElement){
							e += finalElement;
						}else{
							e-= finalElement;
						}
						return e;
					})
					.collect(Collectors.toList());

		}

		System.out.println(sum);
	}
}
