function sequence(n, k) {
const result = [1];

    for (let i = 1; i < n; i++) {
        let start = i - k >= 0 ? i - k : 0;
        let acc = [...result].slice(start, i + 1);;

        let element = acc.reduce((a, c) => a + c, 0);        
        result.push(element);
    }

    return result;
}

console.log(sequence(8, 2));
