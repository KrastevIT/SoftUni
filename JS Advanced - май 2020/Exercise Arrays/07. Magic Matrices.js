function solve(arr) {
    let isMagic = true;

    let isValid = [];

    for (let row = 0; row < arr.length; row++) {
        let sumRow = 0;
        let sumCol = 0;
        isValid[row] = 0;

        for (let col = 0; col < arr.length; col++) {

            sumRow += arr[row][col];
            sumCol += arr[col][row];
        }
        isValid[row] += sumRow + sumCol;
        // if (sumRow !== sumCol) {
        //     return false;
        // }
    }
    let sort = isValid.sort();

    isMagic = sort[0] === sort[isValid.length -1] ? true : false;

    return isMagic;
}

console.log(solve([
    [2, 2, 2],
    [2, 1, 2],
    [2, 2, 2]]));

console.log(solve([[4, 5, 6],
[6, 5, 4],
[5, 5, 5]]));
