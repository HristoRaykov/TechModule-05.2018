function solveProblem14(arr) {
	let map = [];
	for (let line of arr){
		let obj = JSON.parse(line);
		map.push(obj);
	}
	
	map.forEach(obj=>{
		console.log(`Name: ${obj['name']}\nAge: ${obj['age']}\nDate: ${obj['date']}`);
	})

}

solveProblem14([
	'{"name":"Gosho","age":10,"date":"19/06/2005"}',
	'{"name":"Tosho","age":11,"date":"04/04/2005"}',
])