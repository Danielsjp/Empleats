function cargarJSON() {

    let llamada = new XMLHttpRequest();

    let url = "datos.json";

    llamada.onreadystatechange = function ( ) {
        if (this.readyState == 4 && this.status == 200) {
    
        console.log("Recibida la informacion del fichero");
        let datos = JSON.parse(this.responseTex);
        console.log(datos);
    }
}

    console.log("Se envia la peticion");
    
    llamada.open ("GET", url, true) ;
    llamada.send();

}

window.onload = cargarJSON;
    