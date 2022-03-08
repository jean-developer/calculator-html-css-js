
function liveScreen(value) {
    let res = document.getElementById("result");
    if(!res.value){
        res.value = "";
    }
    res.value += value;
}

function clearScreen() {
    document.getElementById("result").value = "";
}
