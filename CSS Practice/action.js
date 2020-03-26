// console.log("Hello World")
// var name1 = "Class Room 7"
// var name2 = "this is JS training "+ name1
// var name3 = 'addition of 1 and 2 is ${1+2}'

// 
// function greet(){
//     console.log('Hello..');
// }

// let sayHello = greet;
// sayHello()

const clickMeBtn = document.querySelector("#clickMeBtn");
const divBox = document.querySelector(".alert");
const hideBtn = document.querySelector("#hideBtn");
const showBtn = document.querySelector("#showBtn");

clickMeBtn.addEventListener('click',()=>{
    divBox.innerText ="Good AfterNoon";
    
})
hideBtn.addEventListener('click',()=>{
    divBox.style.display ="none";
})

showBtn.addEventListener('click',()=>{
    divBox.style.display ="block";
})