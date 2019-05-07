const express = require("express");
const app = express();

const homeController = require("./controllers/home.js");

app.get('/', homeController);

app.listen(3000,()=>{
	console.log(`Listening on http://localhost:3000`);
});