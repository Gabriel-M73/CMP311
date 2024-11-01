const express = require('express');
const app = express();

app.use(express.json());

const dice = [
    { id: 1, name: 'd4'},
    { id: 2, name: 'd6'},
    { id: 3, name: 'd20'}
];

app.get('/', (req, res) => {
    res.send('Hello World!');
});

app.get('/api/dice', (req, res) => {
    res.send(dice);
});

app.post('/api/dice', (req, res) => {
    if (!req.body.name || req.body.name.length < 1) {
        res.status(400).send('name is required and should be more than 1 char');
        return;
    }

    const die = {
        id: dice.length + 1,
        name: req.body.name
    };
    dice.push(die);
    res.send(die);
});

app.put('/api/dice/:id', (req, res) => {
    const die = dice.find(c => c.id === parseInt(req.params.id));
    if (!die) return res.status(404).send('The die with the given ID was not found');

    if (!req.body.name || req.body.name.length < 3) return res.status(400).send('name is required and should be more than 3 chars');
    die.name = req.body.name;
    res.send(die);
});

app.get('/api/dice/:id', (req, res) => {
    const die = dice.find(c => c.id === parseInt(req.params.id));
    if (!die) return res.status(404).send('The die with the given ID was not found');
    res.send(die);
});

app.delete('/api/dice/:id', (req, res) => {
    const die = dice.find(c => c.id === parseInt(req.params.id));
    if (!die) return res.status(404).send('The die with the given ID was not found');

    const index = dice.indexOf(die);
    dice.splice(index, 1);

    res.send(die);
});

const port = process.env.PORT || 3000;
app.listen(port, () => console.log(`listening on port ${port}`));