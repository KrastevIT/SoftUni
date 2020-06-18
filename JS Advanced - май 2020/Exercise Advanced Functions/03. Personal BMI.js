function solve(...input) {
    const name = input[0];
    const age = input[1];
    const weight = input[2];
    const height = input[3];
    const bmi = Math.round((weight / Math.pow(height / 100, 2)));

    const status = (bmi) => {
        if (bmi < 18.5) { return 'underweight'; }
        else if (bmi < 25) { return 'normal'; }
        else if (bmi < 30) { return 'overweight'; }
        else if (bmi >= 30) { return 'obese'; }
    };

    const person = {
        name: name,
        personalInfo: {
            age: age,
            weight: weight,
            height: height
        },
        BMI: bmi,
        status: status(bmi)
    };

    person.status === 'obese' ? person.recommendation = 'admission required' : person;

    return person;
}

console.log(solve('Peter', 29, 75, 182));
console.log(solve('Honey Boo Boo', 9, 57, 137));