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

app.get('/api/faculty', (req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "Gabriel",
        password: "Ninos35MGEL",
        database: "mydb"
    });
    con.connect(function(err) {
        if (err) throw err;
        con.query("SELECT * FROM faculty", function (err, result, fields) {
            if (err) throw err
            else {
                console.log(result);
                res.send(result);
            }
        });
    });
});

app.get('/api/faculty/:id', (req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "Gabriel",
        password: "Ninos35MGEL",
        database: "mydb"
    });

    con.connect(function(err) {
        if (err) throw err;
        con.query("SELECT * FROM faculty WHERE id = " + parseInt(req.params.id), function(err,result) {
            if (err) throw err
            else {
                    console.log(result);
                    if (result == "") return res.status(404).send('No faculty with that id was found');
                                res.send(result);
            }
        });
    });
});

app.post('/api/faculty', (req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "Gabriel",
        password: "Ninos35MGEL",
        database: "mydb"
    });
    con.connect(function(err) {
        facultyLastName = req.body.facultyLast;
        facultyFirstName = req.body.facultyFirst;
        facultyEmail = req.body.facultyEmail;
        if (err) throw err;
        console.log("Connected!");
        var sql = "INSERT INTO faculty (facultyLast, facultyFirst, facultyEmail) VALUES ('"+ facultyLastName +"', '"+ facultyFirstName +"', '"+ facultyEmail +"')";
        con.query(sql, function (err, result) {
          if (err) throw err;
          console.log("1 record inserted");
          res.send(result);
        });
    });
});

app.put('/api/faculty/:id', (req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "Gabriel",
        password: "Ninos35MGEL",
        database: "mydb"
    });
    con.connect(function(err) {
        facultyLastName = req.body.lastNameame;
        facultyFirstName = req.body.facultyFirst;
        facultyEmail = req.body.facultyEmail;
        if (err) throw err;
        var sql = "UPDATE faculty SET facultyLast = '"+ facultyLastName +"', facultyFirst = '"+ facultyFirstName +"', facultyEmail = '"+ facultyEmail +"' WHERE id = " + parseInt(req.params.id);
        con.query(sql, function(err, result) {
            if (err) throw err;

            if (result.affectedRows === 0) {
                res.status(404).send('No faculty with that id was found');
            } else {
                    console.log(result.affectedRows + " record(s) updated");
                    res.send(result);                            
            }
        });
    });
});

app.delete('/api/faculty/:id', (req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "Gabriel",
        password: "Ninos35MGEL",
        database: "mydb"
    });
    con.connect(function(err) {
        const facultyId = req.params.id;

        const checkQuery = `SELECT COUNT(*) AS courseCount FROM courses WHERE facultyId = ?;`;
        con.query(checkQuery, [facultyId], (err, result) => {
            if (err) throw err;
            const courseCount = result[0].courseCount;
            if (courseCount > 0) {
                return res.status(400).send('Faculty member cannot be deleted as they are assigned to one or more courses')
            }
        });

        if (err) throw err;
        var sql = "DELETE FROM faculty WHERE id = " + parseInt(req.params.id);
        con.query(sql, function (err, result) {
          if (err) throw err;

          if (result.affectedRows === 0) {
            res.status(404).send('No faculty with that id was found');
          } else {
                console.log("Number of records deleted: " + result.affectedRows);
                res.send(result);
          }
        });
    });
})

const port = process.env.PORT || 4000;
app.listen(port, () => console.log(`listening on port ${port}`));