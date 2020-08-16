// Start point of code for Welcome

var i = 1;
var images = [];
var time = 5000;

images[0] = "../Content/Images/First.jpg"
images[1] = '../Content/Images/Second.jpg'
images[2] = '../Content/Images/Third.jpg'
images[3] = '../Content/Images/Fourth.jpg'


function changePhoto() {
    document.slide.src = images[i];
    if (i < images.length - 1) {
        i++;
    }
    else {
        i = 0;
    }
    setTimeout(function(){
        changePhoto()
    }, 5000);
}


window.onload = changePhoto;

// End point of code for welcome