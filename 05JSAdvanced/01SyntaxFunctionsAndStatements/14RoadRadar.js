function radar(speed, area) {
    let limit = 0;
    switch (area) {
        case 'residential':
            limit = 20;
            break;
        case 'city':
            limit = 50;
            break;
        case 'interstate':
            limit = 90;
            break;
        case 'motorway':
            limit = 130;
            break;
    }

    let offence = speed - limit;

    if (offence <= 0) {
        return `Driving ${speed} km/h in a ${limit} zone`;
    } else if (offence <= 20){
        let status = 'speeding';
        return `The speed is ${Math.abs(offence)} km/h faster than the allowed speed of ${limit} - ${status}`;
    } else if (offence <= 40){
        let status = 'excessive speeding';
        return `The speed is ${Math.abs(offence)} km/h faster than the allowed speed of ${limit} - ${status}`;
    } else {
        let status = 'reckless driving';
        return `The speed is ${Math.abs(offence)} km/h faster than the allowed speed of ${limit} - ${status}`;
    }
}

console.log(radar(40, 'city'));
console.log(radar(21, 'residential'));
console.log(radar(120, 'interstate'));
console.log(radar(200, 'motorway'));