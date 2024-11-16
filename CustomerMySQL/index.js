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

app.get('/api/customers', (req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "Gabriel",
        password: "Ninos35MGEL",
        database: "mydb"
    });
    con.connect(function(err) {
        if (err) throw err;
        con.query("SELECT * FROM customers", function (err, result, fields) {
            if (err) throw err
            else {
                console.log(result);
                res.send(result);
            }
        });
    });
});

app.get('/api/customers/:id', (req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "Gabriel",
        password: "Ninos35MGEL",
        database: "mydb"
    });

    con.connect(function(err) {
        if (err) throw err;
        con.query("SELECT * FROM customers WHERE id = " + parseInt(req.params.id), function(err,result) {
            if (err) throw err
            else {
                    console.log(result);
                    if (result == "") return res.status(404).send('No customer with that id was found');
                                res.send(result);
            }
        });
    });
});

app.post('/api/customers', (req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "Gabriel",
        password: "Ninos35MGEL",
        database: "mydb"
    });
    con.connect(function(err) {
        if (err) throw err;
        console.log("Connected!");
        var sql = "INSERT INTO customers (name, address) VALUES ('"+ customerName + "', '"+ customerAddress +"')";
        con.query(sql, function (err, result) {
          if (err) throw err;
          console.log("1 record inserted");
        });
      });
});



const port = process.env.PORT || 3000;
app.listen(port, () => console.log(`listening on port ${port}`));