function solution() {

    const recipes = {
        apple: {
            carbohydrate: 1,
            flavour: 2,
            order: ['carbohydrate', 'flavour']
        },
        lemonade: {
            carbohydrate: 10,
            flavour: 20,
            order: ['carbohydrate', 'flavour']
        },
        burger: {
            carbohydrate: 5,
            fat: 7,
            flavour: 3,
            order: ['carbohydrate', 'fat', 'flavour']
        },
        eggs: {
            protein: 5,
            fat: 1,
            flavour: 1,
            order: ['protein', 'fat', 'flavour']
        },
        turkey: {
            protein: 10,
            carbohydrate: 10,
            fat: 10,
            flavour: 10,
            order: ['protein', 'carbohydrate', 'fat', 'flavour']
        }
    };

    const microelements = {
        protein: 0,
        carbohydrate: 0,
        fat: 0,
        flavour: 0
    };

    const operations = {
        restock,
        prepare,
        report
    };

    function restock(element, qty) {
        microelements[element] += qty;
        return 'Success';
    }

    function prepare(recipe, qty) {
        const reqired = Object.assign({}, recipes[recipe]);
        reqired.order.forEach(key => reqired[key] *= qty);

        for (const element of reqired.order) {
            if (microelements[element] < reqired[element]) {
                return `Error: not enough ${element} in stock`;
            }
        }

        reqired.order.forEach(key => microelements[key] -= reqired[key]);

        return 'Success';
    }

    function report() {
        return `protein=${microelements.protein} carbohydrate=${microelements.carbohydrate} fat=${microelements.fat} flavour=${microelements.flavour}`;
    }

    function manager(input) {
        const [command, micro, qty] = input.split(' ');
        return operations[command](micro, Number(qty));
    }

    return manager;
}

let manager = solution();

console.log(manager("restock flavour 50"));  // Success
console.log(manager("prepare lemonade 4"));

console.log(manager("report"));
