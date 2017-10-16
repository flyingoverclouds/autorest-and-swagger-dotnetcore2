Add nugget package : swashbuckle.AspNetCore

in startup.cs/ConfigureService(...) : add
			services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1",
                    new Swashbuckle.AspNetCore.Swagger.Info
                    {
                        Title = "ProjEvaNico",
                        Version = "v1",
                        Description = "A simple api document with swager for project Eva",
                        TermsOfService = "None"
                    }
                 );


            });


in startup.cs/Configure(...) : add
			app.UseSwagger(); // insert swagger generator

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "PrjEva API V1");
            }); // insert API autodocumentation from swagger 


in controllers classe, use the following pattern for method returning json : 
	    [HttpGet]
        [Produces("application/json",Type = typeof(IEnumerable<string>))]
        public IActionResult Get()
        {
            return Json(new string[] { "value1", "value2" });
        }


