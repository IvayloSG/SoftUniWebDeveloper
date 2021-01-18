function weekDay(day) {
    let index = 'error';

    switch (day) {
        case 'Monday':
            index = 1;
            break;
        case 'Tuesday':
            index = 2;
            break;
        case 'Wednesday':
            index = 3;
            break;
        case 'Thursday':
            index = 4;
            break;
        case 'Friday':
            index = 5;
            break;
        case 'Saturday':
            index = 6;
            break;
        case 'Sunday':
            index = 7;
            break;
    }

    return index;
}

console.log(weekDay("Thursday"));