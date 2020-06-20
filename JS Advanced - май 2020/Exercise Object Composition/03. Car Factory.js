function solve(input) {
    const { model, power, color, carriage, wheelsize } = input;
    const engine = engineVolume(power);
    const wheels = getWheels(wheelsize);

    return {
        model: model,
        engine: engine,
        carriage: {
            type: carriage,
            color: color
        },
        wheels: wheels
    };

    function engineVolume(power) {
        if (power <= 90) { return { power: 90, volume: 1800 }; }
        else if (power > 90 && power <= 120) { return { power: 120, volume: 2400 }; }
        else { return { power: 200, volume: 3500 }; }
    }

    function getWheels(wheelsize) {
        const wheels = new Array(4);
        return wheels.fill(wheelsize % 2 === 0 ? wheelsize - 1 : wheelsize);
    }
}

console.log(solve({
    model: 'Opel Vectra',
    power: 110,
    color: 'grey',
    carriage: 'coupe',
    wheelsize: 17
}));