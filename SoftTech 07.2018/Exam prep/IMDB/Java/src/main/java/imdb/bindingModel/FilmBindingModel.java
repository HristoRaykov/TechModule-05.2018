package imdb.bindingModel;

import javax.validation.constraints.NotNull;

public class FilmBindingModel {
	@NotNull
    private String name;
	@NotNull
	private String genre;
	@NotNull
	private String director;
	@NotNull
	private Integer year;
	
	@NotNull
	public String getName() {
		return name;
	}
	
	public void setName(@NotNull String name) {
		this.name = name;
	}
	
	@NotNull
	public String getGenre() {
		return genre;
	}
	
	public void setGenre(@NotNull String genre) {
		this.genre = genre;
	}
	
	@NotNull
	public String getDirector() {
		return director;
	}
	
	public void setDirector(@NotNull String director) {
		this.director = director;
	}
	
	@NotNull
	public Integer getYear() {
		return year;
	}
	
	public void setYear(@NotNull Integer year) {
		this.year = year;
	}
}
