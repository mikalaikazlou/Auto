function initBlockMain() {

    var cars = [{ id: 1, name:"Audi", img: "url('../Content/logo/audi.png')" },
        { id: 2, name:"BMW", img: "url('../Content/logo/bmw.jpg')" },
        { id: 3, name:"Mercedes", img: "url('../Content/logo/mercedes.png')" },
        { id: 4, name:"Tesla", img: "url('../Content/logo/tesla.jpg')" },
        { id: 5, name:"Toyota", img: "url('../Content/logo/toyota.jpg')" }];

    var blockDiv = document.getElementById("main");

    for (let index = 0; index < cars.length; index++) {
        let element = createCarBlock(cars[index].id, cars[index].img, cars[index].name,);
        let elementMark = createCrossMark();
        element.appendChild(elementMark);
        blockDiv.appendChild(element);
    }
}


function createCarBlock(carId, img, name) {
    var elementDiv = document.createElement("div");
    var elementName = document.createElement("h2");
    elementName.innerText = name;
    elementName.style.color = "pink";
    elementName.style.position ="absolute";
    elementDiv.className = "car-contaner";
    elementDiv.id = carId;
    elementDiv.onclick = openChild;
    elementDiv.style.backgroundImage = img;
    elementDiv.appendChild(elementName);
    return elementDiv;
}

function createCrossMark() {
    var elemCross = document.createElement("img");
    elemCross.className = "crossMark";
    elemCross.onclick = deleteDiv;
    return elemCross;
}

function deleteDiv(e) {
    if (confirm("Хотите удалить?")) {
        e.stopPropagation();
        this.parentElement.remove();
    }
    else e.stopPropagation();
}

function openChild() {
    var childWindow = open("../Content/StaticFile/newWin.html", "win2", 'resizable=no,width=200,height=400');
    if (childWindow.opener == null) childWindow.opener = self;
}

function updateMyArray(Value) {
    var classMain = document.getElementById("main");
    if (Value) {
        let elementNew = createCarBlock(1, "url('../Content/logo/audi.png')");
        let elementCross = createCrossMark();
        elementNew.appendChild(elementCross);
        classMain.appendChild(elementNew);
    }
}


function animateImg(funcParam) {
    let getImgHeader = document.getElementById("imgHeader");
    getImgHeader.onclick = function () {
        let start = performance.now();
        let timer = setInterval(function time() {
            let timePassed = performance.now() - start;
            getImgHeader.style.right =timePassed /2 + 'px';
            if (timePassed > 1800) {
                clearInterval(timer)
                funcParam();
            }
        }, 20)
    };
}

function main() {

    let promisRequest = new Promise(function (resolve, reject) {
        var request = new XMLHttpRequest();
        request.open("GET", CONSTANS.getCarUrl);
        request.addEventListener("load", function () {
            if (request.readyState == 4 && request.status == 200) {
                resolve(request.responseText);
            }
            else reject(new Error("Error message: " + request.statusText)
         )});
        request.addEventListener("error", function () {
            reject(new Error("Error errrrrroor!"));
        });
        request.send();
    });

    promisRequest.then(function (response) {
        document.getElementById("output").innerText = response;
    }).catch(() => new Error("oooX"));
   
    animateImg(function () {
        console.log("done!")

    });
    initBlockMain();
}


main();