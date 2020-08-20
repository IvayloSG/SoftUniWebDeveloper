function starRectangle(size) {
    let iteration = Number(size);

    for (let i = 0; i < iteration; i++) {
        let row = "* ".repeat(size);        

        console.log(row);      
    }
}
