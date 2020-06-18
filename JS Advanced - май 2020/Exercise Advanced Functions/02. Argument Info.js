function solve() {
    const types = {};

    for (const item of arguments) {
        const type = typeof (item);

        console.log(`${type}: ${item}`);

        if (!types.hasOwnProperty(type)) {
            types[type] = 0;
        }

        types[type]++;
    }

    Object.entries(types)
    .sort((a, b) => b[1] - a[1])
    .forEach(element => {
     console.log(`${element[0]} = ${element[1]}`);   
    });;
}

solve('cat', 42, function () { console.log('Hello world!'); });