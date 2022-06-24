
function liveScreen(value) {
    let res = document.getElementById("result");
    if(!res.value){
        res.value = "";
    }
    res.value += value;
    console.log(res.value);
}

function clearScreen() {
    document.getElementById("result").value = "";
}

function getAllHistories() {
    const url = "https://localhost:44323/api/CalculatorHistories";
    let result = document.getElementById("historyresults");

    const params = {
        headers: {
            "content-type": "application/json; charset=UTF-8"
        },
        method: "GET"
    };

    fetch(url,params)
    .then(data => {return data.json()})
    .then(res => {
        result.innerHTML = "<pre>" + JSON.stringify(res) + "</pre>";
        console.log(res[0])
    })
    .catch(error => console.log(error));
}

function postAHistory(resultValue){
    
    const url = "https://localhost:44323/api/CalculatorHistories";

    const resultado = eval(resultValue);

    const body = {
        operation: resultValue,
        result: resultado.toString()
    }

    const params = {
        headers: {
            "content-type": "application/json; charset=UTF-8"
        },
        body: JSON.stringify(body),
        method: "POST"
    };


    fetch(url,params)
    .then(data=>{return data.json()})
    .catch(error => console.log(error));
}

function processResult(){
    postAHistory(result.value);
    result.value = eval(result.value||null)
    getAllHistories();
}