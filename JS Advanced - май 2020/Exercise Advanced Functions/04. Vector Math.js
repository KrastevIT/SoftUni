(function solution() {
    return {
        add: (a, b) => {
            return [a[0] + b[0], a[1] + b[1]];
        },

        multiply: (a, b) => {
            return [a[0] * b, a[1] * b];
        },

        length: (a) => {
            return Math.sqrt(Math.pow(a[0], 2) + Math.pow(a[1], 2));
        },

        dot: (a, b) => {
            return a[0] * b[0] + a[1] * b[1];
        },

        cross: (a, b) => {
            return a[0] * b[1] - a[1] * b[0];
        }
    };
})();

