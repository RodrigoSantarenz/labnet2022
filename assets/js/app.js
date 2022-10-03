let nombre, apellido, edad, empresa, genero;
let expLetras = /^[ a-zA-ZñÑáéíóúÁÉÍÓÚ]+$/;
let expNumeros = /^[0-9]+$/;

window.addEventListener("load", function() {
    document.getElementById("form").addEventListener("submit", function(event){
        let hasError = false;
        nombre = document.getElementById("nombre").value;
        apellido = document.getElementById("apellido").value;
        edad = document.getElementById("edad").value;
        empresa = document.getElementById("empresa").value;
        genero = document.querySelector('input[name="genero"]:checked');
    
        if(nombre == null || nombre.length == 0 || !expLetras.test(nombre)) {
            document.getElementById("span-nombre").style.display = "inherit";
            document.getElementById("nombre").style.border= "2px solid #9D1E1E";
            hasError = true;
        }else{
            document.getElementById("nombre").style.border = "2px solid #cacaca"
            document.getElementById("span-nombre").style.display = "none"
        }

        if(apellido == null || apellido.length == 0 || !expLetras.test(apellido)) {
            document.getElementById("span-apellido").style.display = "inherit";
            document.getElementById("apellido").style.border= "2px solid #9D1E1E";
            hasError = true;
        }else{
            document.getElementById("apellido").style.border = "2px solid #cacaca"
            document.getElementById("span-apellido").style.display = "none"
        }

        if(edad == null || edad.length == 0 || !expNumeros.test(edad) || edad < 18) {
            document.getElementById("span-edad").style.display = "inherit";
            document.getElementById("edad").style.border= "2px solid #9D1E1E";
            hasError = true;
        }else{
            document.getElementById("edad").style.border = "2px solid #cacaca"
            document.getElementById("span-edad").style.display = "none"
        }

        if(empresa == null || empresa.length == 0 || !expLetras.test(empresa)) {
            document.getElementById("span-empresa").style.display = "inherit";
            document.getElementById("empresa").style.border= "2px solid #9D1E1E";
            hasError = true;
        }else{
            document.getElementById("empresa").style.border = "2px solid #cacaca"
            document.getElementById("span-empresa").style.display = "none"
        }

        if(!genero) {
            document.getElementById("span-genero").style.display = "inherit";
            hasError = true;
        }else{
            document.getElementById("span-genero").style.display = "none"
        }

        if(hasError) event.preventDefault();
    });

    document.getElementById("borrar").addEventListener("click", function(e){
        e.preventDefault();
        document.getElementById("form").reset();
    });
});