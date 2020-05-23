function solve(params) {
    let number = Number(params[0]);

    let operations = {
        'chop': (x) => x / 2,
        'dice': (x) => Math.sqrt(x),
        'spice': (x) => x + 1,
        'bake': (x) => x * 3,
        'fillet': (x) => x * 0.8
    };

    for (let i = 1; i < params.length; i++) {
        const operation = params[i];
        number = operations[operation](number);
        console.log(number);
    }

}

solve(['32', 'chop', 'chop', 'chop', 'chop', 'chop']);
solve(['9', 'dice', 'spice', 'chop', 'bake', 'fillet']);