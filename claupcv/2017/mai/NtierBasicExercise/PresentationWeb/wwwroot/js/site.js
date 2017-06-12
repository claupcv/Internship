// Write your Javascript code.

$('a.removePerson').click(function (event) {

    var r = confirm("Do you want to delete the Person ?");
    if (r === false) {
        event.preventDefault();
    }     
})

