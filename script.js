let numbers = [2, 5, 13, 7, 6, 4];
let sum = 0;
let avg = 0;

for (let i = 0; i < numbers.length; i++) {
    sum = sum + numbers[i];
}

avg = sum / numbers.length;
alert(avg);