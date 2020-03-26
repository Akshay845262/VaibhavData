var images=[],x=0;
images[0]="msd4.jpg"
images[1]="msd3.jpg"
images[2]="msd6.jpg"

setInterval(()=>{
    console.log("image")
    var img =document.querySelector(".image")
    img.src=images[x];
    x++;
    if(x>=images.length)
    x=0
},1000)