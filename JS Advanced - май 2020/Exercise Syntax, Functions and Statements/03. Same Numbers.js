function solve(x) {
    const numAsText = x.toString();
    let isValid = true;;
    const num = numAsText[0];
    let sum = 0;

    for (let i = 0; i < numAsText.length; i++) {
        sum += Number(numAsText[i]);
        if (num !== numAsText[i]) {
            isValid = false;
        }
    }

    console.log(isValid)
    console.log(sum);
}

solve(1234);