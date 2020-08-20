function toUpperCase(inputString) {
    let result = inputString.match(/\w+/gim).map(x => x.toUpperCase());

    console.log(result.join(", "));
}

toUpperCase("Hi, madafaka bitch shte ti eba maikata")