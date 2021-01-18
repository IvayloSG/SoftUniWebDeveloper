function upper(input) {
    let result = input.match(/\w+/gim).map(x => x.toUpperCase());

    console.log(result.join(", "));
}