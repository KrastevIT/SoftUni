function solve() {
    const juniorTasks = [
        ' is working on a simple task.'
    ];

    const seniorTasks = [
        ' is working on a complicated task.',
        ' is taking time off work.',
        ' is supervising junior workers.'
    ];

    const managerTasks = [
        ' scheduled a meeting.',
        ' is preparing a quarterly report.'
    ];


    class Employee {
        constructor(name, age) {
            this.name = name;
            this.age = age;
            this.salary = 0;
            this.tasks = [];
        }

        work() {
            const currentTask = this.tasks.shift();
            console.log(this.name + currentTask);
            this.tasks.push(currentTask);
        }

        collectSalary() {
            console.log(`${this.name} received ${this.salary} this month.`);
        }
    }

    class Junior extends Employee {
        constructor(name, age) {
            super(name, age);

            juniorTasks.forEach(x => this.tasks.push(x));
        }
    }

    class Senior extends Employee {
        constructor(name, age) {
            super(name, age);

            seniorTasks.forEach(x => this.tasks.push(x));
        }
    }

    class Manager extends Employee {
        constructor(name, age) {
            super(name, age);

            this.dividend = 0;

            managerTasks.forEach(x => this.tasks.push(x));
        }

        collectSalary() {
            console.log(`${this.name} received ${this.salary + this.dividend} this month.`);
        }
    }

    return {
        Junior,
        Senior,
        Manager
    };
}

const people = solve();
const person = new people.Junior('Pesho', 27);

person.work();