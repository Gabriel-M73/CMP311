var mysql = require('mysql2');

var con = mysql.createConnection({
    host: "localhost",
    user: "Gabriel",
    password: "Ninos35MGEL"
});

con.connect(function(err) {
  if (err) throw err;
  console.log("Connected!");
  con.query(sql, function (err, result) {
    if (err) throw err;
    console.log("Result: " + result);
  });
});