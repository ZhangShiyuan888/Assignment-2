function myFunction() {
    var limitInput = document.getElementById('content').value;
    var limit = parseInt(limitInput);
    if (!isNaN(limit)) {//判断是否为数字
        alert("You successfully subscribed for " + limit + " months");
    } else {
        alert(" Error.You didn't fill anything in or something you entered is not a number.");
    }
}
function editFunction() {
    alert("Modified successfully！");
}
function creatFunction() {
    alert("Created Successfully！");
}
function deleteFunction() {
    alert("Deleted successfully！");
}
