## Run locally

### Dotnet Run

```shell
dotnet run --project App/App.csproj
```

https://localhost:7297/weatherforecast

### Docker

Delete all running containers ?

```bash
docker stop $(docker ps -aq)

docker rm $(docker ps -aq)

docker rmi $(docker images -q) # remove all images
```

```bash
docker build -t webapi .
docker run -d -p 5000:80 --name myapp webapi
```

http://localhost:5000/weatherforecast

## Deploy to Heroku (crews-ss)

```bash
heroku login

heroku container:login

docker login --username=_ --password=$(heroku auth:token) registry.heroku.com

docker build -t registry.heroku.com/crews-ss/web .

docker push registry.heroku.com/crews-ss/web

heroku container:release web --app crews-ss
```
