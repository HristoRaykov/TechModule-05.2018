function addRemoveElement(arr) {
	let nums = [];
	for (let line of arr) {
		let tokens = line.split(" ");
		let command = tokens[0];
		if (command === "add") {
			let num = Number(tokens[1]);
			nums.push(num);
		} else if (command === "remove") {
			let index = Number(tokens[1]);
			if (index >= 0 && index < nums.length) {
				nums.splice(index,1);
			}
		}
	}
	nums.forEach(x=>console.log(x));
}

addRemoveElement([
	'add 3',
	'add 5',
	'remove 2',
	'remove 0',
	'add 7',
])