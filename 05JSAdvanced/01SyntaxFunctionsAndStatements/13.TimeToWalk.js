function walk(steps, length, speed) {
    let speedMeters = speed * 1000 / 3600;

    let distance = steps * length;
    let breakTime = Math.floor(distance / 500) * 60;

    let time = distance / speedMeters + breakTime;

    let hours = Math.floor(time / 60 / 60);
    let minutes = Math.floor((time - (hours * 60 * 60)) / 60);
    let seconds = (time - hours * 60 * 60 - minutes * 60);

    return `${hours.toFixed(0).padStart(2, '0')}:${minutes.toFixed(0).padStart(2, '0')}:${seconds.toFixed(0).padStart(2, '0')}`;
}

console.log(walk(4000, 0.60, 5));
console.log(walk(2564, 0.70, 5.5));