var mysql = require('mysql2');
const express = require('express');

const app = express();
app.use(express.json());

app.get('/', (req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "Gabriel",
        password: "Ninos35MGEL",
        database: "mydb"
    });
    con.connect(function(err) {
        if (err) throw err;
        console.log("Connected to database");
    });
    res.send("Connnected to database");
});

app.get('/api/courses', (req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "Gabriel",
        password: "Ninos35MGEL",
        database: "mydb"
    });
    con.connect(function(err) {
        if (err) throw err;
        con.query("SELECT * FROM courses", function (err, result, fields) {
            if (err) throw err
            else {
                console.log(result);
                res.send(result);
            }
        });
    });
});

app.get('/api/courses/:id', (req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "Gabriel",
        password: "Ninos35MGEL",
        database: "mydb"
    });

    con.connect(function(err) {
        if (err) throw err;
        con.query("SELECT * FROM courses WHERE id = " + parseInt(req.params.id), function(err,result) {
            if (err) throw err
            else {
                    console.log(result);
                    if (result == "") return res.status(404).send('No course with that id was found');
                                res.send(result);
            }
        });
    });
});

app.get('/api/courses/schedule/:facultyId', (req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "Gabriel",
        password: "Ninos35MGEL",
        database: "mydb"
    });

    con.connect(function(err) {
        courseNumber = req.body.courseNum;
        coursesName = req.body.courseName;
        enrollmentLimit = req.body.enrollLimit;
        courseFacultyId = req.body.facultyId;
        if (err) throw err;
        var sql = "SELECT c.courseNum, c.courseName, c.enrollLimit, f.facultyLast, f.facultyFirst, f.facultyEmail FROM courses AS c INNER JOIN faculty AS f ON c.facultyId = f.id WHERE f.id = " + parseInt(req.params.facultyId);
        con.query(sql, function(err,result) {
            if (err) throw err
            else {
                    console.log(result);
                    if (result == "") return res.status(404).send('No records with that faculty id was found');
                    res.json(result);
            }
        });
    });
});

app.post('/api/courses', (req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "Gabriel",
        password: "Ninos35MGEL",
        database: "mydb"
    });
    con.connect(function(err) {
        courseNumber = req.body.courseNum;
        coursesName = req.body.courseName;
        enrollmentLimit = req.body.enrollLimit;
        courseFacultyId = req.body.facultyId;
        if (err) throw err;
        console.log("Connected!");
        var sql = "INSERT INTO courses (courseNum, courseName, enrollLimit, facultyId) VALUES ('"+ courseNumber +"', '"+ coursesName +"', '"+ enrollmentLimit +"', '"+ courseFacultyId +"')";
        con.query(sql, function (err, result) {
          if (err) throw err;
          console.log("1 record inserted");
          res.send(result);
        });
    });
});

app.put('/api/courses/:id', (req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "Gabriel",
        password: "Ninos35MGEL",
        database: "mydb"
    });
    con.connect(function(err) {
        courseNumber = req.body.courseNum;
        coursesName = req.body.courseName;
        enrollmentLimit = req.body.enrollLimit;
        courseFacultyId = req.body.facultyId;
        if (err) throw err;
        var sql = "UPDATE courses SET courseNum = '"+ courseNumber +"', courseName = '"+ coursesName +"', enrollLimit = '"+ enrollmentLimit +"', facultyId = '"+ courseFacultyId +"' WHERE id = " + parseInt(req.params.id);
        con.query(sql, function(err, result) {
            if (err) throw err;

            if (result.affectedRows === 0) {
                res.status(404).send('No course with that id was found');
            } else {
                    console.log(result.affectedRows + " record(s) updated");
                    res.send(result);                            
            }
        });
    });
});

app.delete('/api/courses/:id', (req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "Gabriel",
        password: "Ninos35MGEL",
        database: "mydb"
    });
    con.connect(function(err) {
        if (err) throw err;
        var sql = "DELETE FROM courses WHERE id = " + parseInt(req.params.id);
        con.query(sql, function (err, result) {
          if (err) throw err;
          
          if (result.affectedRows === 0) {
            res.status(404).send('No course with that id was found');
          } else {
                console.log("Number of records deleted: " + result.affectedRows);
                res.send(result);
          }
        });
    });
})

const port = process.env.PORT || 5000;
app.listen(port, () => console.log(`listening on port ${port}`));