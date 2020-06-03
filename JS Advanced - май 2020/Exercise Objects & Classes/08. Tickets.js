function solve(tickets, criterion) {
    class Ticket {
        constructor(description) {
            const [destination, price, status] = description.split('|');
            this.destination = destination;
            this.price = Number(price);
            this.status = status;
        }
    }

    return tickets.map(x => new Ticket(x)).sort(comparator);

    function comparator(a, b) {
        try {
            return a[criterion].localeCompare(b[criterion]);
        } catch (error) {
            return a[criterion] - b[criterion];
        }
    }
}

console.log(solve(['Philadelphia|94.20|available',
    'New York City|95.99|available',
    'New York City|95.99|sold',
    'Boston|126.20|departed'],
    'destination'));