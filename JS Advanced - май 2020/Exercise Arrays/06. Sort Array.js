function solve(arr) {
    return arr.sort((a, b) => a.length - b.length || a.toLowerCase().localeCompare(b.toLowerCase())).join('\n');
}


function solveSort(arr) {
    console.log(arr.sort((a, b) => a.length - b.length || a.toLowerCase().localeCompare(b.toLowerCase())).join('\n'));
}

solveSort(['test', 
'Deny', 
'omen', 
'Default']);