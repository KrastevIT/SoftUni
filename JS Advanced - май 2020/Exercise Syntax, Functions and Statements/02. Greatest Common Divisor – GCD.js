function solve(x, y) {
    const small = Math.min(x, y);
    let gcd = 1;

    for (let i = 1; i <= small; i++) {
        if (x % i == 0 && y % i == 0) {
            gcd = i;
        }
    }

    console.log(gcd);
}
