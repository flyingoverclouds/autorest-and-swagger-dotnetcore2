
Install latest node

install autorest : npm install -g autorest

rest autorest : autorest --reset

generate proxy from swagger file : autorest --namespace=Clients.ApiProxy --input-file=http://localhost:8379/swagger/v1/swagger.json --output-folder=Clients.ApiProxy --csharp


