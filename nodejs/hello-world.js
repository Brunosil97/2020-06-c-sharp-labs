console.log('Hello world from npm')

for(let i = 0; i < 10; i++) {
    console.log(i)
}

//set timeout - delay 2 seconds then print something
// setTimeout(() => {
//     console.log("printed after a 2 second delay")
// }, 2000);
// //set interval - print every 2 seconds until stop application

// setInterval(() => {
//     console.log("prints every 2 secs")
// }, 2000);


//array handling
console.log("\n\n Array Handling")
const myArray = [10,20,30];

console.log(myArray);

for(let i = 0; i < myArray.length; i++) {
    console.log(myArray[i])
}

//push and pop, shift and unshift

myArray.push(400);
myArray.push(500);
console.log(myArray);
myArray.pop();
console.log(myArray);
myArray.unshift(5);
myArray.unshift(6);
console.log(myArray);
myArray.shift();
console.log(myArray);