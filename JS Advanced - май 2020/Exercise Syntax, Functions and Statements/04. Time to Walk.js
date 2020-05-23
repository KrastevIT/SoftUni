function solve(steps, footprint, speed) {
    const dist = steps * footprint;
    let time = Math.round(dist / speed * 3.6);
    time += Math.floor(dist / 500) * 60;

    const secounds = time % 60;
    time -= secounds;
    const minutes = (time / 60) % 60;
    time -= minutes * 60;
    const hours = time / 3600;

    console.log(`${pad(hours)}:${pad(minutes)}:${pad(secounds)}`);

    function pad(num) {
        if (num < 10) {
            return '0' + num;
        }
        else {
            return num;
        }
    }
}

solve(4000, 0.60, 5);
solve(2564, 0.70, 5.5);