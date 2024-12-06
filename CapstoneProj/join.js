var mysql = require('mysql2');

var con = mysql.createConnection({
  host: "localhost",
  user: "Gabriel",
  password: "Ninos35MGEL",
  database: "mydb"
});

con.connect(function(err) {
  if (err) throw err;
  var sql = "SELECT courses.facultyId AS course, faculty.id AS facultyId FROM courses JOIN faculty ON courses.facultyId = faculty.id";
  con.query(sql, function (err, result) {
    if (err) throw err;
    console.log(result);
  });
});