function solve(arr) {
    const split = arr.pop();
    console.log(`${arr.join(split)}`);
}

solve(['One',
    'Two',
    'Three',
    'Four',
    'Five',
    '-']);

solve(['How about no?',
    'I',
    'will',
    'not',
    'do',
    'it!',
    '_']);