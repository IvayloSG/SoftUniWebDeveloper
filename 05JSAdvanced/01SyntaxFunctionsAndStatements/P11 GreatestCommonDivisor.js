function greatestDevisor(a, b) {
    let maxDivisor = 1;
    let stoper = Math.min(a, b);

    for (let i = 1; i <= stoper; i++) {
        if (a % i === 0 && b % i === 0) {
            maxDivisor = i;
        }
    }

    console.log(maxDivisor);
}