# Web Api Banco Nación
NET CORE 2.2 Web API con Basic Authentication, con MySQL, hosteada en Heroku

# DEMO
https://web-api-netcore-22-mysql-free.herokuapp.com/api/BancoNacion/

# External Service
https://bna.com.ar/Mobile/CotizadorMobile

# DATABASE FREE CLOUD
https://www.freesqldatabase.com

# CLOUD API
https://heroku.com

# USO DE LA API
- Usar POSTMAN con Basic Authentication 
- username: bna
- password: 123456

## 0) Ejercicio 1
- url: https://web-api-netcore-22-mysql-free.herokuapp.com/api/BancoNacion/
- Metodo: GET
- Autenticacion básica
- Busca en la api del banco las cotizaciones y las inserta en la DDBB

## 1) Ejercicio 2
- url: https://web-api-netcore-22-mysql-free.herokuapp.com/api/BancoNacion/
- Metodo: POST
- Autenticacion básica
- JSON: 
  {
    "id" : "",
    "compra" : "",
    "venta": ""
  }
- Inserta manualmente una cotizacion, previo chequeo del id, en la DDBB y devuelve lo insertado en formato JSON.

## 2) Ejercicio 2
- url: https://web-api-netcore-22-mysql-free.herokuapp.com/api/BancoNacion/GetQuotes
- Metodo: GET
- Autenticacion básica
- Trae las cotizaciones del día de la DDBB.

