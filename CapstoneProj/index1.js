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

app.get('/api/students', (req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "Gabriel",
        password: "Ninos35MGEL",
        database: "mydb"
    });
    con.connect(function(err) {
        if (err) throw err;
        con.query("SELECT * FROM students", function (err, result, fields) {
            if (err) throw err
            else {
                console.log(result);
                res.send(result);
            }
        });
    });
});

app.get('/api/students/:id', (req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "Gabriel",
        password: "Ninos35MGEL",
        database: "mydb"
    });

    con.connect(function(err) {
        if (err) throw err;
        con.query("SELECT * FROM students WHERE id = " + parseInt(req.params.id), function(err,result) {
            if (err) throw err
            else {
                    console.log(result);
                    if (result == "") return res.status(404).send('No customer with that id was found');
                                res.send(result);
            }
        });
    });
});

app.post('/api/students', (req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "Gabriel",
        password: "Ninos35MGEL",
        database: "mydb"
    });
    con.connect(function(err) {
        studentLastName = req.body.lastName;
        studentFirstName = req.body.firstName;
        studentEmail = req.body.studentEmail;
        if (err) throw err;
        console.log("Connected!");
        var sql = "INSERT INTO students (lastName, firstName, studentEmail) VALUES ('"+ studentLastName +"', '"+ studentFirstName +"', '"+ studentEmail +"')";
        con.query(sql, function (err, result) {
          if (err) throw err;
          console.log("1 record inserted");
          res.send(result);
        });
    });
});

app.put('/api/students/:id', (req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "Gabriel",
        password: "Ninos35MGEL",
        database: "mydb"
    });
    con.connect(function(err) {
        studentLastName = req.body.lastNameame;
        studentFirstName = req.body.firstName;
        studentEmail = req.body.studentEmail;
        if (err) throw err;
        var sql = "UPDATE students SET lastName = '"+ studentLastName +"', firstName = '"+ studentFirstName +"', studentEmail = '"+ studentEmail +"' WHERE id = " + parseInt(req.params.id);
        con.query(sql, function(err, result) {
            if (err) throw err;
            console.log(result.affectedRows + "record(s) updated");
            res.send(result);
        });
    });
});

app.delete('/api/students/:id', (req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "Gabriel",
        password: "Ninos35MGEL",
        database: "mydb"
    });
    con.connect(function(err) {
        if (err) throw err;
        var sql = "DELETE FROM students WHERE id = " + parseInt(req.params.id);
        con.query(sql, function (err, result) {
          if (err) throw err;
          console.log("Number of records deleted: " + result.affectedRows);
          res.send(result);
        });
    });
})

const port = process.env.PORT || 3000;
app.listen(port, () => console.log(`listening on port ${port}`));