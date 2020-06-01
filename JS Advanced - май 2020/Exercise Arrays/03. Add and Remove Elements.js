function solve(arr) {
    let list = [];

    for (let i = 1; i <= arr.length; i++) {
        arr[i-1] === 'add' ? list.push(i) : list.pop();
    };

    list.length > 0 ? console.log(list.join('\n')) : console.log('Empty');
}

solve(['add', 
'add', 
'remove', 
'add', 
'add']);