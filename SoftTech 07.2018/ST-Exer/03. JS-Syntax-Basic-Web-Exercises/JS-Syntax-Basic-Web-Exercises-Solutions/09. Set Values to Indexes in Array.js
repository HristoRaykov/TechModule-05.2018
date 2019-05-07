function indexValues(arr) {
	let n = Number(arr[0]);
	let nums = Array(n).fill(0);
	for (let i = 1; i < arr.length; i++) {
		let tokens = arr[i].split(" - ").map(Number);
		let index = tokens[0];
		let value = tokens[1];
		nums[index] = value;
	}
	nums.forEach(x=>console.log(x));
	// for (let i = 0; i < n; i++) {
	// 	if (nums[i]) {
	// 		console.log(nums[i]);
	// 	} else {
	// 		nums[i]=0;
	// 		console.log(nums[i]);
	// 	}
	// }
}

indexValues([
	"3",
	"0 - 5",
	"0 - 6",
	"0 - 7",
])