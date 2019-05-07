function multiplyOrDivide(arr) {
	let n =Number(arr[0]);
	let x =Number(arr[1]);
	let result = 0;
	if (x>=n){
		result=n*x;
	} else {
		result=n/x;
	}
	return result;
}

console.log(multiplyOrDivide(["2", "3"]));