var mysql = require('mysql2');

var con = mysql.createConnection({
  host: "localhost",
  user: "Gabriel",
  password: "Ninos35MGEL",
  database: "mydb"
});

con.connect(function(err) {
  if (err) throw err;
  con.query("SELECT * FROM customers ORDER BY name DESC", function (err, result) {
    if (err) throw err;
    console.log(result);
  });
});