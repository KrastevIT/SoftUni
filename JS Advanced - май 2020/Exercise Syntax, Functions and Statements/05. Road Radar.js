function solve([speed, area]) {
    const limits = { motorway: 130, interstate: 90, city: 50, residential: 20 };

    let print = (speed, limit) => {
        if (speed > limit + 40) {
            console.log(`reckless driving`);
        }
        else if (speed > limit + 20) {
            console.log(`excessive speeding`);
        }
        else if (speed > limit) {
            console.log(`speeding`);
        }
    };

    print(speed, limits[area]);

}

solve([40, 'city']);
solve([21, 'residential']);
solve([120, 'interstate']);
solve([200, 'motorway']);