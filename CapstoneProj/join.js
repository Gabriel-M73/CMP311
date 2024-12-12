var mysql = require('mysql2');

var con = mysql.createConnection({
  host: "localhost",
  user: "Gabriel",
  password: "Ninos35MGEL",
  database: "mydb"
});

con.connect(function(err) {
  if (err) throw err;
  var sql = "SELECT courses.courseNum, courses.courseName, courses.enrollLimit, courses.facultyId, faculty.facultyLast, faculty.facultyFirst, faculty.facultyEmail FROM courses LEFT JOIN faculty ON courses.facultyId = faculty.id";
  con.query(sql, function (err, result) {
    if (err) throw err;
    console.log(result);
  });
});