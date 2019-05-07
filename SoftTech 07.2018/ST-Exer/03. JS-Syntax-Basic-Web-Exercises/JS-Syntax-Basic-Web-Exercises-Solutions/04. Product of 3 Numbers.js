function product(arr) {
	let nums = arr.map(Number);
	let zerosCount = nums.filter(x => x === 0).length;
	let negativeCount = nums.filter(x => x < 0).length;
	let result = "";
	if (zerosCount >0){
		result= "Positive";
	} else {
		if (negativeCount===0 || negativeCount===2){
			result="Positive";
		} else {
			result="Negative";
		}
	}
	return result;
}

console.log(product(["5", "4", "3"]));