function getCapitalCaseWords(arr) {
	let result = [];
	let text = arr.join(",");
	let delimiter = /\W+/;
	let words = text.split(delimiter).filter(x=>x.length>0);
	for (let word of words){
		if (isUpperCase(word)){
			result.push(word);
		}
	}
	console.log(result.join(", "));
	
	function isUpperCase(word){
		if (word===word.toUpperCase()){
			return true;
		} else {
			return false;
		}
	}
}


getCapitalCaseWords(["We start by HTML", "CSS, JavaScript, JSON and REST.",
	"Later we touch some PHP, MySQL and SQL.",
	"Later we play with C#, EF, SQL Server and ASP.NET MVC.",
	"Finally, we touch some Java, Hibernate and Spring.MVC.",
]);