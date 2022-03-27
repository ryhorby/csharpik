var path = window.location.pathname;
console.log(path)

if (path == "/" || path.split("/")[1] == "Home") {
    document.querySelector("#Home").classList.add("current-page");
    console.log("home");
}
if (path.split("/")[1] == "Book") {
    document.querySelector("#Book").classList.add("current-page");
    console.log("book")
}
