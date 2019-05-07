function SumByTown(arr) {
	let objects = arr.map(JSON.parse);
	let towns = {};
	for (let obj of objects) {
		if (!towns[obj.town]) {
			towns[obj.town] = obj.income;
		} else {
			towns[obj.town] += obj.income;
		}
	}
	let townsNames = Object.keys(towns).sort();
	for (let town of townsNames){
		console.log(`${town} -> ${towns[town]}`);
	}
}


SumByTown([
	'{"town":"Sofia","income":200}',
	'{"town":"Varna","income":120}',
	'{"town":"Pleven","income":60}',
	'{"town":"Varna","income":70}',
]);