var mysql = require('mysql2');

var con = mysql.createConnection({
  host: "localhost",
  user: "Gabriel",
  password: "Ninos35MGEL",
  database: "mydb"
});

con.connect(function(err) {
    if (err) throw err;
    console.log("Connected!");
    var sql = "CREATE TABLE students (id INT AUTO_INCREMENT PRIMARY KEY, lastName VARCHAR(255), firstName VARCHAR(255), studentEmail VARCHAR(255))";
    con.query(sql, function (err, result) {
      if (err) throw err;
      console.log("Table created");
    });
});