const Project = require('../models').Project;

module.exports = {
    index: (req, res) => {
    	Project
		    .findAll()
		    .then(projects=>res.render('project/index',{projects:projects}));//projects.dataValues
    },
	
    createGet: (req, res) => {
        res.render('project/create');
    },
	
    createPost: (req, res) => {
        let project = req.body.project;
	    
        Project
	        .create(project)
	        .then(()=>res.redirect('/'));
        
    },
	
    editGet: (req, res) => {
    	let id = req.params.id;
	    
    	Project
		    .findById(id)
		    .then(project=>res.render('project/edit',{project:project}));
    },

    editPost: (req, res) => {
        let body = req.body.project;//or req.body
		let id = req.params.id;
		
		Project
			.findById(id)
			.then(project=>{
				// project.title=body.title;
				// project.budget=body.budget;
				// project.description=body.description;
				project
					.updateAttributes(body)
					.then(res.redirect('/'));
			});
    },

    deleteGet: (req, res) => {
        let id = req.params.id;
        
        Project
	        .findById(id)
	        .then(project=>res.render('project/delete', {project:project}));
    },
	
    deletePost: (req, res) => {
	    let id = req.params.id;
	
	    Project
		    .findById(id)
		    .then(project=>{
		    	project
				    .destroy()
				    .then(res.redirect('/'));
		    });
    }

};