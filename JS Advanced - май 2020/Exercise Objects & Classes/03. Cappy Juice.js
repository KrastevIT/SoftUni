function solve(input) {
    let juices = {};
    let bottles = {};
    for (let juice of input) {
        let [name, quantity] = juice.split(' => ');
        quantity = Number(quantity);

        if (!juices.hasOwnProperty(name)) {
            juices[name] = 0;
        }

        juices[name] += quantity;

        if (juices[name] >= 1000) {
            bottles[name] = Math.trunc(juices[name] / 1000);
        }
    };

    for (const name in bottles) {
        console.log(`${name} => ${bottles[name]}`);
    }
}

solve(['Orange => 2000',
    'Peach => 1432',
    'Banana => 450',
    'Peach => 600',
    'Strawberry => 549']);

solve(['Kiwi => 234',
    'Pear => 2345',
    'Watermelon => 3456',
    'Kiwi => 4567',
    'Pear => 5678',
    'Watermelon => 6789']);