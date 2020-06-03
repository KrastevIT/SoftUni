function solve(input) {
    let items = Array.from(input.sort());

    let letter = String.empty;

    items.forEach(element => {
        let currentLetter = element.substring(0, 1);
        if (letter !== currentLetter) {
            letter = currentLetter;
            console.log(letter);
        }

        let [key, value] = element.split(' : ');
        console.log(`${key}: ${value}`);
    });
}

solve(['Banana : 2',
    `Rubic's Cube : 5`,
    'Raspberry P : 4999',
    'Rolex : 100000',
    'Rollon : 10',
    'Rali Car : 2000000',
    'Pesho : 0.000001',
    'Barrel : 10']);