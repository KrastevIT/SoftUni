class Company {
    constructor() {
        this.departments = [];
    }

    addEmployee(username, salary, position, department) {
        this._validateParam(username);
        this._validateParam(salary);
        this._validateParam(position);
        this._validateParam(department);
        if (salary < 0) { throw new Error('Invalid input!'); }

        let find = this.departments.find(x => x.username === username && x.department === department);
        if (find === undefined) {
            let current =
            {
                'username': username,
                'salary': salary,
                'position': position,
                'department': department
            };

            this.departments.push(current);
            return `New employee is hired. Name: ${username}. Position: ${position}`;
        }
    };


    bestDepartment() {
        const bestDepartment = this.departments.sort((a, b) => a.salary > b.salary).map(x => x.department)[0];
        const averageSalary = this.departments
            .filter(x => x.department === bestDepartment)
            .map(x => x.salary)
            .reduce((a, b) => a + b, 0)
            / this.departments.filter(x => x.department === bestDepartment).length;

        const emp = this.departments
            .filter(x => x.department === bestDepartment)
            .sort((a, b) => b.salary - a.salary || a.username.localeCompare(b.username));

        let result = [
            `Best Department is: ${bestDepartment}`,
            `Average salary: ${averageSalary.toFixed(2)}`
        ];

        emp.forEach(x => result.push(`${x.username} ${x.salary} ${x.position}`));

        return result.join('\n');
    }

    _validateParam(param) {
        if (param === '' || param === undefined || param === null) {
            throw new Error('Invalid input!');
        }
    }

}


let c = new Company();
c.addEmployee("Stanimir", 2000, "engineer", "Construction");
c.addEmployee("Pesho", 1500, "electrical engineer", "Construction");
c.addEmployee("Slavi", 500, "dyer", "Construction");
c.addEmployee("Stan", 2000, "architect", "Construction");
c.addEmployee("Stanimir", 1200, "digital marketing manager", "Marketing");
c.addEmployee("Pesho", 1000, "graphical designer", "Marketing");
c.addEmployee("Gosho", 1350, "HR", "Human resources");
console.log(c.bestDepartment());