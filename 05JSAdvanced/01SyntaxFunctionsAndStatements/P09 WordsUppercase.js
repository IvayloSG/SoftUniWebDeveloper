function toUpperCase(inputString) {
    let result = inputString.match(/\w+/gim).map(x => x.toUpperCase());

    console.log(result.join(", "));
}