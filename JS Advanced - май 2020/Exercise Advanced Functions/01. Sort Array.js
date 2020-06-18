function solve() {
    const numbers = arguments[0];
    const arg = arguments[1];
    if (arg === 'asc') {
        return numbers.sort((a, b) => a - b);
    } else {
        return numbers.sort((a, b) => b - a);
    }
}

solve([14, 7, 17, 6, 8], 'asc');
solve([14, 7, 17, 6, 8], 'desc');