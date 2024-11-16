var mysql = require('mysql2');

var con = mysql.createConnection({
  host: "localhost",
  user: "Gabriel",
  password: "Ninos35MGEL",
  database: "mydb"
});

con.connect(function(err) {
  if (err) throw err;
  var sql = "UPDATE customers SET address = 'Canyon 123' WHERE address = 'Valley 345'";
  con.query(sql, function (err, result) {
    if (err) throw err;
    console.log(result.affectedRows + " record(s) updated");
  });
});